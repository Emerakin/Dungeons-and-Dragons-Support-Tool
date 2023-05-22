using System.Collections.Generic;
using System.Windows.Forms;
using BackendLogic.DM;

namespace Formulars.DM
{
    public partial class MonsterStatBlock : Form
    {
        public MonsterStatBlock()
        {
            InitializeComponent();
        }

        public MonsterStatBlock(Monster monster)
        {
            InitializeComponent();
            Init(monster);
        }

        private void Init(Monster monster)
        {
            labelName.Text = monster.Info.Name;
            labelSTA.Text = monster.SizeTypeAligmentToString();
            labelArmorClass.Text = $"Armor class: {monster.Info.ArmorClass}";
            labelHitPoints.Text = $"Hit points: {monster.HitPointsToString()}";
            labelSpeed.Text = $"Speed: {monster.SpeedToString()}";
            labelChallangeRating.Text = $"Challange rating: {monster.ChallangeRatingToString()}";
            labelProficiency.Text = $"Proficiency bonus: {monster.ProficiencyBonusToString()}";
            labelStrength.Text = $"STR\n{monster.AbilityScores[AbilityScore.Strength].Item1} {monster.AbilityScoreModifierToString(AbilityScore.Strength)}";
            labelDexterity.Text = $"DEX\n{monster.AbilityScores[AbilityScore.Dexterity].Item1} {monster.AbilityScoreModifierToString(AbilityScore.Dexterity)}";
            labelConstituion.Text = $"CON\n{monster.AbilityScores[AbilityScore.Constitution].Item1} {monster.AbilityScoreModifierToString(AbilityScore.Constitution)}";
            labelIntelligence.Text = $"INT\n{monster.AbilityScores[AbilityScore.Intelligence].Item1} {monster.AbilityScoreModifierToString(AbilityScore.Intelligence)}";
            labelWisdom.Text = $"WIS\n{monster.AbilityScores[AbilityScore.Wisdom].Item1} {monster.AbilityScoreModifierToString(AbilityScore.Wisdom)}";
            labelCharisma.Text = $"CHA\n{monster.AbilityScores[AbilityScore.Charisma].Item1} {monster.AbilityScoreModifierToString(AbilityScore.Charisma)}";
            labelSavingThrows.Text = $"Saving throws: {monster.SavingThrowsToString()}";
            labelSkillsValues.Text = monster.SkillsToString();
            labelDmgVulValues.Text = monster.DamageVulnerabilitiesToString();
            labelDmgResValues.Text = monster.DamageResistancesToString();
            labelDmgImmValues.Text = monster.DamageImmunitiesToString();
            labelConditionImmunitiesValues.Text = monster.ConditionImmunitiesToString();
            labelSensesValues.Text = monster.SensesToString();
            labelLanguagesValues.Text = monster.LanguagesToString();
            InitTraits(monster.Traits);
            InitActions(monster.Actions);
        }

        private void InitTraits(List<BackendLogic.DM.Trait> traits)
        {
            flowLayoutPanelTraits.Controls.Clear();
            foreach (BackendLogic.DM.Trait t in traits)
            {
                flowLayoutPanelTraits.Controls.Add(new TraitFinal(t.Name, t.Description));
            }
        }

        private void InitActions(List<BackendLogic.DM.Action> actions)
        {
            flowLayoutPanelActions.Controls.Clear();
            foreach (BackendLogic.DM.Action a in actions)
            {
                flowLayoutPanelActions.Controls.Add(new ActionFinal(a.Name, a.Description));
            }
        }

        public void UpdateInformation(Monster monster)
        {
            Init(monster);
        }
    }
}
