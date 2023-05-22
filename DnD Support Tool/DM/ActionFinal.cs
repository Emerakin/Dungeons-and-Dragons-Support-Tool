using System;
using System.Windows.Forms;

namespace Formulars.DM
{
    public partial class ActionFinal : UserControl
    {
        private int _originalHeight;

        public ActionFinal()
        {
            InitializeComponent();
            Init();
        }

        public ActionFinal(string name, string description)
        {
            InitializeComponent();
            labelName.Text = name;
            richTextBoxDescription.Text = description;
            Init();
        }

        private void Init()
        {
            _originalHeight = Height;
            Height = 31;
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            if (Height == 31)
            {
                Height = _originalHeight;
            }
            else
            {
                Height = 31;
            }
        }
    }
}
