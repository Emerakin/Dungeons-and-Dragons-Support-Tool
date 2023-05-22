using System;
using System.Collections.Generic;
using System.Linq;

namespace BackendLogic.DM
{
    public class Monster
    {
        public BasicInformation Info { get; set; }
        public List<Tuple<MovementSpeedType, int>> MovementSpeed { get; set; }
        public Dictionary<AbilityScore, Tuple<int, int>> AbilityScores { get; set; }
        public List<AbilityScore> SavingThrows { get; set; }
        public List<Skill> Skills { get; set; }
        public DamageTypeModifiers DamageTypeModifiers { get; set; }
        public List<Condition> ConditionImmunities { get; set; }
        public List<Tuple<Sense, int>> Senses { get; set; }
        public List<Language> Languages { get; set; }
        public int Telepathy { get; set; }
        public List<Trait> Traits { get; set; }
        public List<Action> Actions { get; set; }

        public Monster(BasicInformation info, List<Tuple<MovementSpeedType, int>> movementSpeed, Dictionary<AbilityScore, Tuple<int, int>> abilityScores,
            List<AbilityScore> savingThrows, List<Skill> skills, DamageTypeModifiers damageTypeModifiers, List<Condition> conditionImmunities,
            List<Tuple<Sense, int>> senses, List<Language> languages, int telepathy, List<Trait> traits, List<Action> actions)
        {
            Info = info;
            MovementSpeed = movementSpeed;
            AbilityScores = abilityScores;
            SavingThrows = savingThrows;
            Skills = skills;
            DamageTypeModifiers = damageTypeModifiers;
            ConditionImmunities = conditionImmunities;
            Senses = senses;
            Languages = languages;
            Telepathy = telepathy;
            Actions = actions;
            Traits = traits;
        }

        public string SizeTypeAligmentToString()
        {
            return $"{Info.Size} {Info.Type}, {Info.Aligment.AligmentToString()}";
        }

        private int GetXpFromChallangeRating(float challangeRating)
        {
            switch (challangeRating)
            {
                case 0:
                    return 0;
                case 0.125f:
                    return 25;
                case 0.25f:
                    return 50;
                case 0.5f:
                    return 100;
                case 1:
                    return 200;
                case 2:
                    return 450;
                case 3:
                    return 700;
                case 4:
                    return 1100;
                case 5:
                    return 1800;
                case 6:
                    return 2300;
                case 7:
                    return 2900;
                case 8:
                    return 3900;
                case 9:
                    return 5000;
                case 10:
                    return 5900;
                case 11:
                    return 7200;
                case 12:
                    return 8400;
                case 13:
                    return 10000;
                case 14:
                    return 11500;
                case 15:
                    return 13000;
                case 16:
                    return 15000;
                case 17:
                    return 18000;
                case 18:
                    return 20000;
                case 19:
                    return 22000;
                case 20:
                    return 25000;
                case 21:
                    return 33000;
                case 22:
                    return 41000;
                case 23:
                    return 50000;
                case 24:
                    return 62000;
                case 25:
                    return 75000;
                case 26:
                    return 90000;
                case 27:
                    return 105000;
                case 28:
                    return 120000;
                case 29:
                    return 135000;
                case 30:
                    return 155000;
                default:
                    return 0;
            }
        }

        public string ChallangeRatingToString()
        {
            if (Info.ChallangeRating >= 1 || Info.ChallangeRating == 0)
            {
                return $"{Info.ChallangeRating} ({GetXpFromChallangeRating(Info.ChallangeRating)} XP)";
            }
            switch (Info.ChallangeRating)
            {
                case 0.5f:
                    return $"1/2 +{GetXpFromChallangeRating(Info.ChallangeRating)}";
                case 0.25f:
                    return $"1/4 +{GetXpFromChallangeRating(Info.ChallangeRating)}";
                case 0.125f:
                    return $"1/8 +{GetXpFromChallangeRating(Info.ChallangeRating)}";
                default:
                    return "";
            }
        }

        public string ProficiencyBonusToString()
        {
            return $"+{Info.ProficiencyBonus}";
        }

        public string HitPointsToString()
        {
            return $"{Info.Hp} ({Info.DiceCount}{Info.HitDice} + {Info.DiceCount}D{AbilityScores[AbilityScore.Constitution].Item2})";
        }

        public string SpeedToString()
        {
            return MovementSpeed.Select(speed => $"{speed.Item1} {speed.Item2} ft.").Aggregate((a, b) => string.Join("; ", a, b));
        }

        public string AbilityScoreModifierToString(AbilityScore abilityScore)
        {
            int value = 0;
            switch (abilityScore)
            {
                case AbilityScore.Strength:
                    value = AbilityScores[AbilityScore.Strength].Item2;
                    break;
                case AbilityScore.Dexterity:
                    value = AbilityScores[AbilityScore.Strength].Item2;
                    break;
                case AbilityScore.Constitution:
                    value = AbilityScores[AbilityScore.Strength].Item2;
                    break;
                case AbilityScore.Intelligence:
                    value = AbilityScores[AbilityScore.Strength].Item2;
                    break;
                case AbilityScore.Wisdom:
                    value = AbilityScores[AbilityScore.Strength].Item2;
                    break;
                case AbilityScore.Charisma:
                    value = AbilityScores[AbilityScore.Strength].Item2;
                    break;
                default:
                    return "";
            }
            if (value >= 0)
            {
                return $"+{value}";
            }
            return $"{value}";
        }

        public string SavingThrowsToString()
        {
            if (SavingThrows.Count == 0)
            {
                return "";
            }
            return SavingThrows.Select(st => $"{st} {AbilityScores[st].Item2}").Aggregate((a, b) => string.Join("; ", a, b));
        }

        private string GetSkillBonus(Skill skill)
        {
            int result = AbilityScores[skill.Modifier].Item2;
            if (skill.ProficiencyType == ProficiencyType.Proficiency)
            {
                result += Info.ProficiencyBonus;
            }
            else
            {
                result += (2 * Info.ProficiencyBonus);
            }
            if (result >= 0)
            {
                return $"+{result}";
            }
            return $"{result}";
        }

        public string SkillsToString()
        {
            if (Skills.Count == 0)
            {
                return "";
            }
            return Skills.Select(skill => $"{skill.Type.SkillTypeToString()} {GetSkillBonus(skill)}").Aggregate((a, b) => string.Join("; ", a, b));
        }

        public string DamageVulnerabilitiesToString()
        {
            if (DamageTypeModifiers.DamageTypeVulnerabilities.Count == 0)
            {
                return "";
            }
            return DamageTypeModifiers.DamageTypeVulnerabilities
                .Select(type => $"{type.DamageTypeToString()}")
                .Aggregate((a, b) => string.Join("; ", a, b));
        }

        public string DamageResistancesToString()
        {
            if (DamageTypeModifiers.DamageTypeResistances.Count == 0)
            {
                return "";
            }
            return DamageTypeModifiers.DamageTypeResistances
                .Select(type => $"{type.DamageTypeToString()}")
                .Aggregate((a, b) => string.Join("; ", a, b));
        }

        public string DamageImmunitiesToString()
        {
            if (DamageTypeModifiers.DamageTypeImmunities.Count == 0)
            {
                return "";
            }
            return DamageTypeModifiers.DamageTypeImmunities
                .Select(type => $"{type.DamageTypeToString()}")
                .Aggregate((a, b) => string.Join("; ", a, b));
        }

        public string ConditionImmunitiesToString()
        {
            if (ConditionImmunities.Count == 0)
            {
                return "";
            }
            return ConditionImmunities
                .Select(condition => $"{condition}")
                .Aggregate((a, b) => string.Join("; ", a, b));
        }

        public string SensesToString()
        {
            if (Senses.Count == 0)
            {
                return "";
            }
            var senses = Senses.Select(sense => $"{sense.Item1} {sense.Item2} ft.").ToList();
            int passivePerceptionValue = 10 + AbilityScores[AbilityScore.Wisdom].Item2;
            foreach (Skill skill in Skills)
            {
                if (skill.Type == SkillType.Perception)
                {
                    passivePerceptionValue += skill.ProficiencyType == ProficiencyType.Proficiency ? Info.ProficiencyBonus : (Info.ProficiencyBonus * 2);
                }
            }
            senses.Add($"Passive perception {passivePerceptionValue}");
            return senses.Aggregate((a, b) => string.Join("; ", a, b));
        }

        public string LanguagesToString()
        {
            if (Languages.Count == 0)
            {
                return "";
            }
            return Languages
                .Select(language => language != Language.Telepathy ? $"{language.LanguageToString()}" : $"{language} {Telepathy} ft.")
                .Aggregate((a, b) => string.Join("; ", a, b));
        }
    }
}
