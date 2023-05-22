using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendLogic.DM;

namespace Formulars.DM
{
    public partial class NewMonster : Form
    {
        private MonsterCommandExecutor _commandExecutor;
        TextBox[] _abilityScores;
        CheckBox[] _conditionImmunities;
        TextBox[] _movementSpeeds;
        CheckBox[] _languages;
        CheckBox[] _skillProficiecies;
        CheckBox[] _skillExpertise;
        TextBox[] _senses;
        CheckBox[] _savingThrowProficiencies;
        CheckBox[] _damageTypeVulnerabilities;
        CheckBox[] _damageTypeResistances;
        CheckBox[] _damageTypeImmunities;
        List<Trait> _traits;
        List<Action> _actions;
        Trait _traitToEdit;
        Action _actionToEdit;

        public NewMonster(MonsterCommandExecutor commandExecutor)
        {
            InitializeComponent();
            _commandExecutor = commandExecutor;
            Init();
        }

        public NewMonster()
        {
            InitializeComponent();
            _commandExecutor = new MonsterCommandExecutor();
            Init();
        }

        private void Init()
        {
            _abilityScores = new TextBox[] { textBoxStrength, textBoxDexterity, textBoxConstitution, textBoxIntelligence, textBoxWisdom, textBoxCharisma };

            _conditionImmunities = new CheckBox[] { checkBoxBlinded, checkBoxCharmed, checkBoxDeafened, checkBoxExhaustion, checkBoxFrightened, checkBoxGrappled, checkBoxIncapacitated,
                checkBoxInvisible, checkBoxParalyzed, checkBoxPetrified, checkBoxPoisoned, checkBoxProne, checkBoxRestrained, checkBoxStunned, checkBoxUnconscious };

            _movementSpeeds = new TextBox[] { textBoxWalking, textBoxClimbing, textBoxSwimming, textBoxFlying, textBoxBurrowing };

            _languages = new CheckBox[] { checkBoxAbyssal, checkBoxCelestial, checkBoxCommon, checkBoxDeepSpeech, checkBoxDraconic, checkBoxDwarvish, checkBoxElvish, checkBoxGiant,
                checkBoxGnomish, checkBoxGoblin, checkBoxHalfling, checkBoxInfernal, checkBoxOrc, checkBoxPrimordial, checkBoxSylvan, checkBoxUndercommon, checkBoxTelepathy};

            _skillProficiecies = new CheckBox[] { checkBoxAcrobaticsProficiency, checkBoxAnimalHandlingProficiency, checkBoxArcanaProficiency, checkBoxAthleticsProficiency,
                checkBoxDeceptionProficiency, checkBoxHistoryProficiency, checkBoxInsightProficiency, checkBoxIntimidationProficiency, checkBoxInvestigationProficiency,
                checkBoxMedicineProficiency, checkBoxNatureProficiency, checkBoxPerceptionProficiency, checkBoxPerformanceProficiency, checkBoxPersuationProficiency,
                checkBoxReligionProficiency, checkBoxSleightOfHandProficiency, checkBoxStealthProficiency, checkBoxSurvivalProficiency };

            _skillExpertise = new CheckBox[] { checkBoxAcrobaticscExpertise, checkBoxAnimalHandlingExpertise, checkBoxArcanaExpertise, checkBoxAthleticsExpertise,
                checkBoxDeceptionExpertise, checkBoxHistoryExpertise, checkBoxInsightExpertise, checkBoxIntimidationExpertise, checkBoxInvestigationExpertise,
                checkBoxMedicineExpertise, checkBoxNatureExpertise, checkBoxPerceptionExpertise, checkBoxPerformanceExpertise, checkBoxPersuationExpertise,
                checkBoxReligionExpertise, checkBoxSleightOfHandExpertise, checkBoxStealthExpertise, checkBoxSurvivalExpertise };

            _senses = new TextBox[] { textBoxDarkvision, textBoxTruesight, textBoxBlindsight, textBoxTremorsense };

            _savingThrowProficiencies = new CheckBox[] { checkBoxStrength, checkBoxDexterity, checkBoxConstitution, checkBoxIntelligence, checkBoxWisdom, checkBoxCharisma };

            _damageTypeVulnerabilities = new CheckBox[] { checkBoxAcidV, checkBoxColdV, checkBoxFireV, checkBoxForceV, checkBoxLightingV, checkBoxNecroticV, checkBoxPoisonV,
                checkBoxPsychicV, checkBoxRadiantV, checkBoxThunderV, checkBoxSlashingV, checkBoxPiercingV, checkBoxBludgeoningV, checkBoxMagicalV, checkBoxNonmagicalV, checkBoxNonsilverV };

            _damageTypeResistances = new CheckBox[] { checkBoxAcidR, checkBoxColdR, checkBoxFireR, checkBoxForceR, checkBoxLightingR, checkBoxNecroticR, checkBoxPoisonR,
                checkBoxPsychicR, checkBoxRadiantR, checkBoxThunderR, checkBoxSlashingR, checkBoxPiercingR, checkBoxBludgeoningR, checkBoxMagicalR, checkBoxNonmagicalR, checkBoxNonsilverR };

            _damageTypeImmunities = new CheckBox[] { checkBoxAcidI, checkBoxColdI, checkBoxFireI, checkBoxForceI, checkBoxLightingI, checkBoxNecroticI, checkBoxPoisonI,
                checkBoxPsychicI, checkBoxRadiantI, checkBoxThunderI, checkBoxSlashingI, checkBoxPiercingI, checkBoxBludgeoningI, checkBoxMagicalI, checkBoxNonmagicalI, checkBoxNonsilverI };

            _traits = new List<Trait>();
            _actions = new List<Action>();
            _traitToEdit = null;
            _actionToEdit = null;
            ChangeActionPanelVisibility(false);
            ChangeTraitPanelVisibility(false);
        }

        public async void NewMonsterWrongSave()
        {
            textBoxName.BackColor = Color.FromArgb(255, 243, 214);
            textBoxAC.BackColor = Color.FromArgb(255, 243, 214);
            textBoxCR.BackColor = Color.FromArgb(255, 243, 214);
            comboBoxAligment.BackColor = Color.FromArgb(255, 243, 214);
            comboBoxSize.BackColor = Color.FromArgb(255, 243, 214);
            comboBoxType.BackColor = Color.FromArgb(255, 243, 214);
            comboBoxHitDice.BackColor = Color.FromArgb(255, 243, 214);
            textBoxDiceCount.BackColor = Color.FromArgb(255, 243, 214);
            foreach (TextBox abilityScore in _abilityScores)
            {
                abilityScore.BackColor = Color.FromArgb(255, 243, 214);
            }
            textBoxWalking.BackColor = Color.FromArgb(255, 243, 214);
            await Task.Delay(1000);
            textBoxName.BackColor = Color.FromArgb(247, 233, 204);
            textBoxAC.BackColor = Color.FromArgb(247, 233, 204);
            textBoxCR.BackColor = Color.FromArgb(247, 233, 204);
            comboBoxAligment.BackColor = Color.FromArgb(247, 233, 204);
            comboBoxSize.BackColor = Color.FromArgb(247, 233, 204);
            comboBoxType.BackColor = Color.FromArgb(247, 233, 204);
            comboBoxHitDice.BackColor = Color.FromArgb(247, 233, 204);
            textBoxDiceCount.BackColor = Color.FromArgb(247, 233, 204);
            foreach (TextBox abilityScore in _abilityScores)
            {
                abilityScore.BackColor = Color.FromArgb(247, 233, 204);
            }
            textBoxWalking.BackColor = Color.FromArgb(247, 233, 204);
        }

        private void ChangeActionPanelVisibility(bool newVisibility)
        {
            panelActionNew.Visible = newVisibility;
            panelActionsHeaderDelim.Visible = newVisibility;
            panelActionsHeader.Visible = newVisibility;
        }

        private void ChangeTraitPanelVisibility(bool newVisiblity)
        {
            panelTraitNew.Visible = newVisiblity;
            panelTraitsHeaderDelim.Visible = newVisiblity;
            panelTraitsHeader.Visible = newVisiblity;
        }

        private void ButtonActionsAddNew_Click(object sender, EventArgs e)
        {
            ChangeActionPanelVisibility(true);
        }

        private void ButtonTraitsAddNew_Click(object sender, EventArgs e)
        {

            ChangeTraitPanelVisibility(true);
        }

        private async void NewTraitWrongSave()
        {
            textBoxTraitsNewName.BackColor = Color.FromArgb(255, 243, 214);
            richTextBoxTraitsNewDecription.BackColor = Color.FromArgb(255, 243, 214);
            await Task.Delay(1000);
            textBoxTraitsNewName.BackColor = Color.FromArgb(247, 233, 204);
            richTextBoxTraitsNewDecription.BackColor = Color.FromArgb(247, 233, 204);
        }

        private void ButtonTraitsNewSave_Click(object sender, EventArgs e)
        {
            if (textBoxTraitsNewName.Text == "" || richTextBoxTraitsNewDecription.Text == "")
            {
                NewTraitWrongSave();
                return;
            }
            if (_traitToEdit == null)
            {
                Trait newTrait = new Trait(textBoxTraitsNewName.Text, richTextBoxTraitsNewDecription.Text);
                newTrait.EditTraitEvent += EditTrait;
                newTrait.DeleteTraitEvent += DeleteTrait;
                flowLayoutPanelTraits.Controls.Add(newTrait);
                _traits.Add(newTrait);
            }
            else
            {
                _traitToEdit.Edit(textBoxTraitsNewName.Text, richTextBoxTraitsNewDecription.Text);
                _traitToEdit = null;
            }
            ChangeTraitPanelVisibility(false);
            textBoxTraitsNewName.Text = string.Empty;
            richTextBoxTraitsNewDecription.Text = string.Empty;
        }

        private void ButtonTraitsNewDiscard_Click(object sender, EventArgs e)
        {
            ChangeTraitPanelVisibility(false);
            textBoxTraitsNewName.Text = string.Empty;
            richTextBoxTraitsNewDecription.Text = string.Empty;
        }

        private void EditTrait(Trait source, EditTraitOrActionEventArgs e)
        {
            if (panelTraitNew.Visible)
            {
                return;
            }
            ChangeTraitPanelVisibility(true);
            textBoxTraitsNewName.Text = e.Name;
            richTextBoxTraitsNewDecription.Text = e.Description;
            _traitToEdit = source;
        }

        private void DeleteTrait(Trait source, EventArgs e)
        {
            source.EditTraitEvent -= EditTrait;
            source.DeleteTraitEvent -= DeleteTrait;
            flowLayoutPanelTraits.Controls.Remove(source);
            _traits.Remove(source);
        }

        private async void NewActionWrongSave()
        {
            textBoxActionsNewName.BackColor = Color.FromArgb(255, 243, 214);
            richTextBoxActionsNewDescription.BackColor = Color.FromArgb(255, 243, 214);
            await Task.Delay(1000);
            textBoxActionsNewName.BackColor = Color.FromArgb(247, 233, 204);
            richTextBoxActionsNewDescription.BackColor = Color.FromArgb(247, 233, 204);
        }

        private void ButtonActionsNewSave_Click(object sender, EventArgs e)
        {
            if (textBoxActionsNewName.Text == "" || richTextBoxActionsNewDescription.Text == "")
            {
                NewActionWrongSave();
                return;
            }
            if (_actionToEdit == null)
            {
                Action newAction = new Action(textBoxActionsNewName.Text, richTextBoxActionsNewDescription.Text);
                newAction.EditActionEvent += EditAction;
                newAction.DeleteActionEvent += DeleteAction;
                flowLayoutPanelActions.Controls.Add(newAction);
                _actions.Add(newAction);
            }
            else
            {
                _actionToEdit.Edit(textBoxActionsNewName.Text, richTextBoxActionsNewDescription.Text);
                _actionToEdit = null;
            }
            ChangeActionPanelVisibility(false);
            textBoxActionsNewName.Text = string.Empty;
            richTextBoxActionsNewDescription.Text = string.Empty;
        }

        private void ButtonActionsNewDiscard_Click(object sender, EventArgs e)
        {
            ChangeActionPanelVisibility(false);
            textBoxActionsNewName.Text = string.Empty;
            richTextBoxActionsNewDescription.Text = string.Empty;
        }

        private void EditAction(Action source, EditTraitOrActionEventArgs e)
        {
            if (panelActionNew.Visible)
            {
                return;
            }
            ChangeActionPanelVisibility(true);
            textBoxActionsNewName.Text = e.Name;
            richTextBoxActionsNewDescription.Text = e.Description;
            _actionToEdit = source;
        }

        private void DeleteAction(Action source, EventArgs e)
        {
            source.EditActionEvent -= EditAction;
            source.EditActionEvent -= EditAction;
            flowLayoutPanelActions.Controls.Remove(source);
            _actions.Remove(source);
        }

        private void UpdateHpLabel()
        {
            if (comboBoxHitDice.Text == "" || textBoxDiceCount.Text == "")
            {
                labelHitPoints.Text = string.Empty;
                return;
            }
            int diceCount = int.Parse(textBoxDiceCount.Text);
            float hpPerDice = int.Parse(comboBoxHitDice.Text.Substring(1)) / 2 + 0.5f;
            int conHp = textBoxConstitution.Text == "" ? 0 : ((int)Math.Floor((int.Parse(textBoxConstitution.Text) - 10) / 2.0f));
            if (conHp < 0)
            {
                labelHitPoints.Text = $"{Math.Floor(diceCount * hpPerDice) + conHp * diceCount} ({diceCount}{comboBoxHitDice.Text.ToLower()} - {Math.Abs(diceCount * conHp)})";
            }
            else
            {
                labelHitPoints.Text = $"{Math.Floor(diceCount * hpPerDice) + conHp * diceCount} ({diceCount}{comboBoxHitDice.Text.ToLower()} + {diceCount * conHp})";
            }

        }

        private void ComboBoxHitDice_TextChanged(object sender, EventArgs e)
        {
            UpdateHpLabel();
        }

        private void TextBoxDiceCount_TextChanged(object sender, EventArgs e)
        {
            UpdateHpLabel();
        }

        private void ComboBoxSize_TextChanged(object sender, EventArgs e)
        {
            comboBoxHitDice.SelectedIndex = comboBoxSize.SelectedIndex;
        }

        private void TextBoxConstitution_TextChanged(object sender, EventArgs e)
        {
            UpdateHpLabel();
        }

        private void TextBoxOnlyInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        public Monster SaveNewMonster()
        {
            return _commandExecutor.CreateMonster(textBoxName.Text,
                textBoxAC.Text,
                textBoxCR.Text,
                comboBoxAligment.Text,
                comboBoxSize.Text,
                comboBoxType.Text,
                comboBoxHitDice.Text,
                textBoxDiceCount.Text,
                _abilityScores.Select(box => box.Text),
                _conditionImmunities.Select(box => box.Checked),
                _movementSpeeds.Select(box => box.Text),
                _languages.Select(box => box.Checked),
                _skillProficiecies.Select(box => box.Checked),
                _skillExpertise.Select(box => box.Checked),
                _senses.Select(box => box.Text),
                _savingThrowProficiencies.Select(box => box.Checked),
                _damageTypeVulnerabilities.Select(box => box.Checked),
                _damageTypeResistances.Select(box => box.Checked),
                _damageTypeImmunities.Select(box => box.Checked),
                textBoxTelepathy.Text,
                _traits.Select(trait => trait.GetTraitInformation()),
                _actions.Select(action => action.GetActionInformation())
                );
        }

        public bool UpdateMonster(Monster monster)
        {
            Monster newMonster = SaveNewMonster();
            if (newMonster == null)
            {
                NewMonsterWrongSave();
                return false;
            }
            _commandExecutor.UpdateMonster(monster, newMonster);
            return true;
        }

        private int GetHitDiceIndex(int hitDice)
        {
            switch (hitDice)
            {
                case 4:
                    return 0;
                case 6:
                    return 1;
                case 8:
                    return 2;
                case 10:
                    return 3;
                case 12:
                    return 4;
                case 20:
                    return 5;
                default:
                    return 0;
            }
        }

        private void SetMonsterBasicInformation(BasicInformation information)
        {
            textBoxName.Text = information.Name;
            textBoxAC.Text = information.ArmorClass.ToString();
            textBoxCR.Text = information.ChallangeRating.ToString();
            comboBoxAligment.SelectedIndex = (int)information.Aligment;
            comboBoxSize.SelectedIndex = (int)information.Size;
            comboBoxType.SelectedIndex = (int)information.Type;
            comboBoxHitDice.SelectedIndex = GetHitDiceIndex(information.HitDice);
            textBoxDiceCount.Text = information.DiceCount.ToString();
        }

        private void SetMonsterAbiltiyScores(Dictionary<AbilityScore, Tuple<int, int>> abilityScores)
        {
            foreach (var score in abilityScores)
            {
                _abilityScores[(int)score.Key].Text = score.Value.Item1.ToString();
            }
        }

        private void SetMonsterMovementSpeed(List<Tuple<MovementSpeedType, int>> movements)
        {
            foreach (var movement in movements)
            {
                _movementSpeeds[(int)movement.Item1].Text = movement.Item2.ToString();
            }
        }

        private void SetMonsterSkills(List<Skill> skills)
        {
            foreach (var skill in skills)
            {
                if (skill.ProficiencyType == ProficiencyType.Proficiency)
                {
                    _skillProficiecies[(int)skill.Type].Checked = true;
                }
                else
                {
                    _skillExpertise[(int)skill.Type].Checked = true;
                }
            }
        }

        private void SetMonsterSavingThrows(List<AbilityScore> savingThrows)
        {
            foreach (var savingThrow in savingThrows)
            {
                _savingThrowProficiencies[(int)savingThrow].Checked = true;
            }
        }

        private void SetMonsteronditionImmunities(List<Condition> conditionImmunities)
        {
            foreach (var conditionImmunity in conditionImmunities)
            {
                _conditionImmunities[(int)conditionImmunity].Checked = true;
            }
        }

        private void SetMonsterLanguages(List<Language> languages)
        {
            foreach (var language in languages)
            {
                _languages[(int)language].Checked = true;
            }
        }

        private void SetMonsterSenses(List<Tuple<Sense, int>> senses)
        {
            foreach (var sense in senses)
            {
                _senses[(int)sense.Item1].Text = sense.Item2.ToString();
            }
        }

        private void SetMonsterDamageTypeModifiers(DamageTypeModifiers damageTypeModifiers)
        {
            foreach (var mod in damageTypeModifiers.DamageTypeVulnerabilities)
            {
                _damageTypeVulnerabilities[(int)mod].Checked = true;
            }
            foreach (var mod in damageTypeModifiers.DamageTypeResistances)
            {
                _damageTypeResistances[(int)mod].Checked = true;
            }
            foreach (var mod in damageTypeModifiers.DamageTypeImmunities)
            {
                _damageTypeImmunities[(int)mod].Checked = true;
            }
        }

        private void SetMonsterTraits(List<BackendLogic.DM.Trait> traits)
        {
            foreach (var trait in traits)
            {
                Trait newTrait = new Trait(trait.Name, trait.Description);
                newTrait.EditTraitEvent += EditTrait;
                newTrait.DeleteTraitEvent += DeleteTrait;
                flowLayoutPanelTraits.Controls.Add(newTrait);
                _traits.Add(newTrait);
            }
        }

        private void SetMonsterActions(List<BackendLogic.DM.Action> actions)
        {
            foreach (var action in actions)
            {
                Action newAction = new Action(action.Name, action.Description);
                newAction.EditActionEvent += EditAction;
                newAction.DeleteActionEvent += DeleteAction;
                flowLayoutPanelActions.Controls.Add(newAction);
                _actions.Add(newAction);
            }
        }

        public void SetMonsterForm(Monster monster)
        {
            if (monster == null)
            {
                return;
            }
            SetMonsterBasicInformation(monster.Info);
            SetMonsterAbiltiyScores(monster.AbilityScores);
            SetMonsterMovementSpeed(monster.MovementSpeed);
            SetMonsterSkills(monster.Skills);
            SetMonsterSavingThrows(monster.SavingThrows);
            SetMonsteronditionImmunities(monster.ConditionImmunities);
            SetMonsterLanguages(monster.Languages);
            SetMonsterSenses(monster.Senses);
            SetMonsterDamageTypeModifiers(monster.DamageTypeModifiers);
            SetMonsterTraits(monster.Traits);
            SetMonsterActions(monster.Actions);
        }
    }
}
