using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendLogic.PC;

namespace Formulars.PC
{
    public partial class PlayerScreen : Form
    {
        private Init _init;
        private Form _mainBodyForm;
        private CharacterCommandExecutor _commandExecutor;
        private Timer _timer;
        public PlayerScreen() : this(new Init())
        {
            
        }

        public PlayerScreen(Init init)
        {
            InitializeComponent();
            _init = init;
            panelNewCharacter.Visible = false;
            _commandExecutor = new CharacterCommandExecutor();
            foreach (Character character in _commandExecutor.GetCharacters())
            {
                CharacterHeader newCharacterHeader = new CharacterHeader(character, _commandExecutor);
                newCharacterHeader.ShowCharacterEvent += ShowCharacterEvent;
                newCharacterHeader.DeleteCharacterEvent += DeleteCharacterEvent;
                flowLayoutPanelCharacters.Controls.Add(newCharacterHeader);
            }
            _timer = new Timer
            {
                Interval = 1000 * 60 * 5
            };
            _timer.Tick += OnTimerTick;
        }

        private async void OnTimerTick(object sender, EventArgs e)
        {
            await Task.Run(() => _commandExecutor.SaveCharacters());
        }

        private void ButtonAddNewCharacter_Click(object sender, EventArgs e)
        {
            panelNewCharacter.Visible = true;
        }

        private void ButtonNewCharacterDiscard_Click(object sender, EventArgs e)
        {
            textBoxNewCharacterHp.Text = "";
            textBoxNewCharacterName.Text = "";
            textBoxNewCharacterWeight.Text = "";
            panelNewCharacter.Visible = false;
        }

        private void TextBoxNewCharacterHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxNewCharacterWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public async void NewCharacterWrongSave()
        {
            textBoxNewCharacterHp.BackColor = Color.FromArgb(255, 243, 214);
            textBoxNewCharacterName.BackColor = Color.FromArgb(255, 243, 214);
            textBoxNewCharacterWeight.BackColor = Color.FromArgb(255, 243, 214);
            await Task.Delay(1000);
            textBoxNewCharacterHp.BackColor = Color.FromArgb(247, 233, 204);
            textBoxNewCharacterName.BackColor = Color.FromArgb(247, 233, 204);
            textBoxNewCharacterWeight.BackColor = Color.FromArgb(247, 233, 204);
        }

        private void ButtonNewCharacterSave_Click(object sender, EventArgs e)
        {
            Character character = _commandExecutor.CreateCharacter(textBoxNewCharacterName.Text, textBoxNewCharacterHp.Text,
                textBoxNewCharacterWeight.Text);
            if (character == null)
            {
                NewCharacterWrongSave();
                return;
            }
            _commandExecutor.AddCharacter(character);
            CharacterHeader newCharacterHeader = new CharacterHeader(character, _commandExecutor);
            newCharacterHeader.ShowCharacterEvent += ShowCharacterEvent;
            newCharacterHeader.DeleteCharacterEvent += DeleteCharacterEvent;
            flowLayoutPanelCharacters.Controls.Add(newCharacterHeader);
            ButtonNewCharacterDiscard_Click(this, EventArgs.Empty);
            _commandExecutor.SaveCharacters();
        }

        private void DeleteCharacterEvent(CharacterHeader source, EventArgs e)
        {
            if (source.Sheet.Equals(_mainBodyForm))
            {
                panelBody.Controls.Clear();
                _mainBodyForm.Close();
            }
            source.ShowCharacterEvent -= ShowCharacterEvent;
            source.DeleteCharacterEvent -= DeleteCharacterEvent;
            flowLayoutPanelCharacters.Controls.Remove(source);
            _commandExecutor.RemoveCharacter(source.Character);
            _commandExecutor.SaveCharacters();
        }

        private void ShowCharacterEvent(CharacterHeader source, EventArgs e)
        {
            if (source.Sheet.Equals(_mainBodyForm))
            {
                return;
            }
            if (_mainBodyForm != null)
            {
                panelBody.Controls.Clear();
            }
            _mainBodyForm = source.Sheet;
            _mainBodyForm.TopLevel = false;
            _mainBodyForm.Dock = DockStyle.Fill;
            _mainBodyForm.Show();
            _mainBodyForm.BringToFront();
            panelBody.Controls.Add(_mainBodyForm);
        }

        // Source: https://rjcodeadvance.com/iu-moderno-temas-multicolor-aleatorio-resaltar-boton-form-activo-winform-c/

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LabelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private async void ButtonExit_Click(object sender, EventArgs e)
        {
            await _commandExecutor.AwaitTasks();
            Application.Exit();
        }

        private async void ButtonBack_Click(object sender, EventArgs e)
        {
            await _commandExecutor.AwaitTasks();
            _init.Show();
            Close();
        }
    }
}
