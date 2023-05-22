using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BackendLogic.DM;

namespace Formulars.DM
{
    public partial class DungeonMasterScreen : Form
    {
        private Init _init;
        private Form _mainBodyForm;
        private MonsterCommandExecutor _commandExecutor;
        private MonsterHeader _monsterToEdit;

        public DungeonMasterScreen() : this(new Init())
        {
            
        }

        public DungeonMasterScreen(Init init)
        {
            InitializeComponent();
            _init = init;
            _commandExecutor = new MonsterCommandExecutor();
            panelFilterMonster.Visible = false;
            panelSaveDiscardNewMonster.Visible = false;
            comboBoxFilterMonsterAligment.SelectedIndex = 0;
            comboBoxFilterMonsterSize.SelectedIndex = 0;
            comboBoxFilterMonsterType.SelectedIndex = 0;
            foreach (Monster monster in _commandExecutor.GetMonsters())
            {
                MonsterHeader newMonsterHeader = new MonsterHeader(monster);
                newMonsterHeader.ShowMonsterEvent += ShowMonster;
                newMonsterHeader.EditMonsterEvent += EditMonster;
                newMonsterHeader.DeleteMonsterEvent += DeleteMonster;
                flowLayoutPanelMonsters.Controls.Add(newMonsterHeader);
            }
            _monsterToEdit = null;
        }

        // Source: https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LabelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void ButtonExit_Click(object sender, EventArgs e)
        {
            await _commandExecutor.AwaitTasks();
            Application.Exit();
        }

        private void ButtonFilterMonsters_Click(object sender, EventArgs e)
        {
            if (panelSaveDiscardNewMonster.Visible)
            {
                return;
            }
            panelFilterMonster.Visible = !panelFilterMonster.Visible;
        }

        private void AddNewMonsterForm()
        {
            if (_mainBodyForm is NewMonster)
            {
                return;
            }
            if (_mainBodyForm != null)
            {
                panelBody.Controls.Clear();
            }
            NewMonster newMonsterForm = new NewMonster(_commandExecutor);
            panelFilterMonster.Visible = false;
            panelSaveDiscardNewMonster.Visible = true;
            _mainBodyForm = newMonsterForm;
            if (_monsterToEdit != null)
            {
                newMonsterForm.SetMonsterForm(_monsterToEdit.Monster);
            }
            _mainBodyForm.TopLevel = false;
            _mainBodyForm.Dock = DockStyle.Fill;
            _mainBodyForm.Show();
            _mainBodyForm.BringToFront();
            panelBody.Controls.Add(_mainBodyForm);
        }

        private void ButtonAddNewMonster_Click(object sender, EventArgs e)
        {
            AddNewMonsterForm();
        }

        private void DiscardNewMonster()
        {
            panelBody.Controls.Clear();
            panelSaveDiscardNewMonster.Visible = false;
            _mainBodyForm.Close();
            _mainBodyForm = null;
            _monsterToEdit = null;
        }

        private void ButtonNewMonsterDicard_Click(object sender, EventArgs e)
        {
            DiscardNewMonster();
        }

        private void ResetFilter()
        {
            textBoxFilterMonsterName.Text = string.Empty;
            comboBoxFilterMonsterAligment.SelectedIndex = 0;
            comboBoxFilterMonsterSize.SelectedIndex = 0;
            comboBoxFilterMonsterType.SelectedIndex = 0;
            MonsterFilterChanged();
        }

        private void ButtonNewMonsterSave_Click(object sender, EventArgs e)
        {
            if (!(_mainBodyForm is NewMonster))
            {
                return;
            }
            NewMonster form = (NewMonster)_mainBodyForm;
            if (_monsterToEdit != null)
            {
                if (form.UpdateMonster(_monsterToEdit.Monster))
                {
                    _monsterToEdit.UpdateInformation();
                    _monsterToEdit = null;
                    DiscardNewMonster();
                    ResetFilter();
                    _commandExecutor.SaveMonsters();
                }
                return;
            }
            Monster monster = form.SaveNewMonster();
            if (monster == null)
            {
                ((NewMonster)_mainBodyForm).NewMonsterWrongSave();
                return;
            }
            MonsterHeader newHeader = new MonsterHeader(monster);
            newHeader.ShowMonsterEvent += ShowMonster;
            newHeader.EditMonsterEvent += EditMonster;
            newHeader.DeleteMonsterEvent += DeleteMonster;
            flowLayoutPanelMonsters.Controls.Add(newHeader);
            _commandExecutor.AddMonster(monster);
            ResetFilter();
            DiscardNewMonster();
            _commandExecutor.SaveMonsters();
        }

        private void ShowMonster(MonsterHeader source, EventArgs e)
        {
            if (panelSaveDiscardNewMonster.Visible || (_mainBodyForm != null && _mainBodyForm.Equals(source.MonsterStatBlockCorrect)))
            {
                return;
            }
            panelBody.Controls.Clear();
            _mainBodyForm = source.MonsterStatBlockCorrect;
            _mainBodyForm.TopLevel = false;
            _mainBodyForm.Dock = DockStyle.Fill;
            _mainBodyForm.Show();
            _mainBodyForm.BringToFront();
            panelBody.Controls.Add(_mainBodyForm);
        }

        private void EditMonster(MonsterHeader source, EventArgs e)
        {
            _monsterToEdit = source;
            AddNewMonsterForm();
        }

        private void DeleteMonster(MonsterHeader source, EventArgs e)
        {
            if (source.MonsterStatBlockCorrect.Equals(_mainBodyForm))
            {
                panelBody.Controls.Clear();
                _mainBodyForm.Close();
            }
            source.ShowMonsterEvent -= ShowMonster;
            source.DeleteMonsterEvent -= DeleteMonster;
            source.EditMonsterEvent -= EditMonster;
            flowLayoutPanelMonsters.Controls.Remove(source);
            _commandExecutor.RemoveMonster(source.Monster);
            _commandExecutor.SaveMonsters();
        }

        private void MonsterFilterChanged()
        {
            string name = textBoxFilterMonsterName.Text;
            Aligment aligment = _commandExecutor.ParseAligment(comboBoxFilterMonsterAligment.SelectedItem as string);
            BackendLogic.DM.Type type = _commandExecutor.ParseType(comboBoxFilterMonsterType.SelectedItem as string);
            Size size = _commandExecutor.ParseSize(comboBoxFilterMonsterSize.SelectedItem as string);
            foreach (MonsterHeader monsterHeader in flowLayoutPanelMonsters.Controls)
            {
                if ((monsterHeader.Monster.Info.Name.Contains(name))
                    && (monsterHeader.Monster.Info.Aligment == aligment || aligment == Aligment.None)
                    && (monsterHeader.Monster.Info.Type == type || type == BackendLogic.DM.Type.None)
                    && (monsterHeader.Monster.Info.Size == size || size == BackendLogic.DM.Size.None))
                {
                    monsterHeader.Visible = true;
                }
                else
                {
                    monsterHeader.Visible = false;
                }
            }
        }

        private void ComboBoxFilterMonsterSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MonsterFilterChanged();
        }

        private void ComboBoxFilterMonsterType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MonsterFilterChanged();
        }

        private void ComboBoxFilterMonsterAligment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MonsterFilterChanged();
        }

        private void TextBoxFilterMonsterName_TextChanged(object sender, EventArgs e)
        {
            MonsterFilterChanged();
        }

        private async void ButtonBack_Click(object sender, EventArgs e)
        {
            await _commandExecutor.AwaitTasks();
            _init.Show();
            Close();
        }
    }
}
