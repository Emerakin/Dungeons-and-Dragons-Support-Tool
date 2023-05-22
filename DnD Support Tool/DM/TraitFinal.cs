using System;
using System.Windows.Forms;

namespace Formulars
{
    public partial class TraitFinal : UserControl
    {
        private int _originalHeight;

        public TraitFinal()
        {
            InitializeComponent();
            Init();
        }

        public TraitFinal(string name, string description)
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
