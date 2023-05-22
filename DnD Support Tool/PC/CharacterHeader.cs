using System;
using System.Windows.Forms;
using BackendLogic.PC;

namespace Formulars.PC
{
    public partial class CharacterHeader : UserControl
    {
        public Character Character { get; set; }
        public CharacterSheet Sheet { get; set; }
        public CharacterHeader()
        {
            InitializeComponent();
            Height = 61;
        }

        public delegate void ShowCharacterEventHandler(CharacterHeader source, EventArgs args);
        public event ShowCharacterEventHandler ShowCharacterEvent;
        public delegate void DeleteCharacterEventHandler(CharacterHeader source, EventArgs args);
        public event DeleteCharacterEventHandler DeleteCharacterEvent;

        public CharacterHeader(Character character, CharacterCommandExecutor commandExecutor)
        {
            InitializeComponent();
            Character = character;
            labelName.Text = character.Name;
            Sheet = new CharacterSheet(character, commandExecutor);
            Height = 61;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Height = 90;
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            ShowCharacterEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            DeleteCharacterEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Height = 61;
        }
    }
}
