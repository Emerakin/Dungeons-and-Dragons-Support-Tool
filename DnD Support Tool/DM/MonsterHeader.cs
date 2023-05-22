using System;
using System.Windows.Forms;
using BackendLogic.DM;

namespace Formulars.DM
{
    public partial class MonsterHeader : UserControl
    {
        public Monster Monster;
        public MonsterStatBlock MonsterStatBlockCorrect;
        public MonsterHeader()
        {
            InitializeComponent();
            Height = 61;
        }

        public delegate void ShowMonsterEventHandler(MonsterHeader source, EventArgs args);
        public event ShowMonsterEventHandler ShowMonsterEvent;
        public delegate void DeleteMonsterEventHandler(MonsterHeader source, EventArgs args);
        public event DeleteMonsterEventHandler DeleteMonsterEvent;
        public delegate void EditMonsterEventHandler(MonsterHeader source, EventArgs args);
        public event EditMonsterEventHandler EditMonsterEvent;

        public MonsterHeader(Monster monster)
        {
            InitializeComponent();
            Monster = monster;
            MonsterStatBlockCorrect = new MonsterStatBlock(monster);
            labelName.Text = monster.Info.Name;
            Height = 61;
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            ShowMonsterEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditMonsterEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Height = 90;
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            DeleteMonsterEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Height = 61;
        }

        public void UpdateInformation()
        {
            labelName.Text = Monster.Info.Name;
            MonsterStatBlockCorrect.UpdateInformation(Monster);
        }
    }
}
