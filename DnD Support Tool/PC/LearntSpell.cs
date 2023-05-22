using System;
using System.Windows.Forms;
using BackendLogic.PC;

namespace Formulars.PC
{
    public partial class LearntSpell : UserControl
    {
        public Spell Spell { get; set; }
        private int _originalHeight;

        public delegate void DeleteLearntSpellEventHandler(LearntSpell source, EventArgs args);
        public event DeleteLearntSpellEventHandler DeleteLearntSpell;
        public delegate void EditLearntSpellEventHandler(LearntSpell source, EventArgs args);
        public event EditLearntSpellEventHandler EditLearntSpell;

        public LearntSpell()
        {
            InitializeComponent();
            _originalHeight = Height;
            Height = 31;
        }

        public LearntSpell(Spell spell)
        {
            InitializeComponent();
            Spell = spell;
            _originalHeight = Height;
            Height = 31;
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            labelName.Text = Spell.Name;
            labelLevel.Text = Spell.Level.SpellLevelToString();
            labelSchool.Text = Spell.School.SpellSchoolToString();
            labelRange.Text = Spell.Range;
            labelComponents.Text = Spell.ComponentsToString();
            labelCastingTime.Text = Spell.CastingTime + (Spell.Ritual ? " R" : "");
            labelDuration.Text = Spell.Duration + (Spell.Concentration ? " C" : "");
            richTextBoxDescription.Text = Spell.Description;
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

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteLearntSpell?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditLearntSpell?.Invoke(this, EventArgs.Empty);
        }
    }
}
