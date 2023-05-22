using System;
using System.Windows.Forms;
using BackendLogic.DM;

namespace Formulars.DM
{
    public partial class Trait : UserControl
    {
        private int _originalHeight;

        public delegate void EditTraitEventHandler(Trait source, EditTraitOrActionEventArgs e);
        public event EditTraitEventHandler EditTraitEvent;
        public delegate void DeleteTraitEventHandler(Trait source, EventArgs e);
        public event DeleteTraitEventHandler DeleteTraitEvent;

        public Trait()
        {
            InitializeComponent();
            Init();
        }

        public Trait(string name, string description)
        {
            InitializeComponent();
            labelName.Text = name;
            richTextBoxDescription.Text = description;
            Init();
        }

        private void Init()
        {
            _originalHeight = Height;
            Height = 61;
        }

        public Tuple<string, string> GetTraitInformation()
        {
            return new Tuple<string, string>(labelName.Text, richTextBoxDescription.Text);
        }

        public void Edit(string newName, string newDescription)
        {
            labelName.Text = newName;
            richTextBoxDescription.Text = newDescription;
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            if (Height == 61)
            {
                Height = _originalHeight;
            }
            else
            {
                Height = 61;
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditTraitEvent?.Invoke(this, new EditTraitOrActionEventArgs(labelName.Text, richTextBoxDescription.Text));
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteTraitEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
