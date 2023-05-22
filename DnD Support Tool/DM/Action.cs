using System;
using System.Windows.Forms;
using BackendLogic.DM;

namespace Formulars.DM
{
    public partial class Action : UserControl
    {
        private int _originalHeight;

        public delegate void EditActionEventHandler(Action source, EditTraitOrActionEventArgs e);
        public event EditActionEventHandler EditActionEvent;
        public delegate void DeleteActionEventHandler(Action source, EventArgs e);
        public event DeleteActionEventHandler DeleteActionEvent;
        
        public Action()
        {
            InitializeComponent();
            Init();
        }

        public Action(string name, string description)
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

        public Tuple<string, string> GetActionInformation()
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

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteActionEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditActionEvent?.Invoke(this, new EditTraitOrActionEventArgs(labelName.Text, richTextBoxDescription.Text));
        }
    }
}
