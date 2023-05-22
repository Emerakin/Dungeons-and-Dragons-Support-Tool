namespace BackendLogic.DM
{
    public class MonsterDataParser
    {

        public MonsterDataParser() { }

        public Aligment ParseStringToAligment(string aligment)
        {
            switch (aligment)
            {
                case "Any":
                    return Aligment.Any;
                case "Unaligned":
                    return Aligment.Unaligned;
                case "Lawful Good":
                    return Aligment.LawfulGood;
                case "Neutral Good":
                    return Aligment.NeutralGood;
                case "Chaotic Good":
                    return Aligment.ChaoticGood;
                case "Lawful Neutral":
                    return Aligment.LawfulNeutral;
                case "True Neutral":
                    return Aligment.TrueNeutral;
                case "Chaotic Neutral":
                    return Aligment.ChaoticNeutral;
                case "Lawful Evil":
                    return Aligment.LawfulEvil;
                case "Neutral Evil":
                    return Aligment.NeutralEvil;
                case "Chaotic Evil":
                    return Aligment.ChaoticEvil;
                default:
                    return Aligment.None;
            }
        }

        public Size ParseStringToSize(string size)
        {
            switch (size)
            {
                case "Tiny":
                    return Size.Tiny;
                case "Small":
                    return Size.Small;
                case "Medium":
                    return Size.Medium;
                case "Large":
                    return Size.Large;
                case "Huge":
                    return Size.Huge;
                case "Gargantuan":
                    return Size.Gargantuan;
                default:
                    return Size.None;
            }
        }

        public Type ParseStringToType(string type)
        {
            switch (type)
            {
                case "Abberation":
                    return Type.Abberation;
                case "Beast":
                    return Type.Beast;
                case "Celestial":
                    return Type.Celestial;
                case "Construct":
                    return Type.Construct;
                case "Dragon":
                    return Type.Dragon;
                case "Elemental":
                    return Type.Elemental;
                case "Fey":
                    return Type.Fey;
                case "Fiend":
                    return Type.Fiend;
                case "Giant":
                    return Type.Giant;
                case "Humanoid":
                    return Type.Humanoid;
                case "Monstrosity":
                    return Type.Monstrosity;
                case "Ooze":
                    return Type.Ooze;
                case "Plant":
                    return Type.Plant;
                case "Undead":
                    return Type.Undead;
                default:
                    return Type.None;
            }
        }

        public int ParseStringToHitDice(string hitDice)
        {
            switch (hitDice.ToUpper())
            {
                case "D4":
                    return 4;
                case "D6":
                    return 6;
                case "D8":
                    return 8;
                case "D10":
                    return 10;
                case "D12":
                    return 12;
                case "D20":
                    return 20;
                default:
                    return -1;
            }
        }

        public SkillType ParseStringToSkillType(string skillType)
        {
            switch (skillType)
            {
                case "Athletics":
                    return SkillType.Athletics;
                case "Acrobatics":
                    return SkillType.Acrobatics;
                case "SleightOfHand":
                    return SkillType.SleightOfHand;
                case "Stealth":
                    return SkillType.Stealth;
                case "Arcana":
                    return SkillType.Arcana;
                case "History":
                    return SkillType.History;
                case "Investigation":
                    return SkillType.Investigation;
                case "Nature":
                    return SkillType.Nature;
                case "Religion":
                    return SkillType.Religion;
                case "AnimalHandling":
                    return SkillType.AnimalHandling;
                case "Insight":
                    return SkillType.Insight;
                case "Medicine":
                    return SkillType.Medicine;
                case "Perception":
                    return SkillType.Perception;
                case "Survival":
                    return SkillType.Survival;
                case "Deception":
                    return SkillType.Deception;
                case "Intimidation":
                    return SkillType.Intimidation;
                case "Performance":
                    return SkillType.Performance;
                case "Persuation":
                    return SkillType.Persuation;
                default:
                    return SkillType.None;
            }
        }

        public float ParseStringToChallangeRating(string cr)
        {
            int res;
            if (int.TryParse(cr, out res))
            {
                if (0 <= res && res <= 30)
                {
                    return res;
                }
            }
            switch(cr)
            {
                case "1/2":
                    return 0.5f;
                case "0.5":
                    return 0.5f;
                case "1/4":
                    return 0.25f;
                case "0.25":
                    return 0.25f;
                case "1/8":
                    return 0.125f;
                case "0.125":
                    return 0.125f;
                default:
                    return -1;
            }
        }

        public AbilityScore GetSkillModifier(SkillType skill)
        {
            switch (skill)
            {
                case SkillType.Athletics:
                    return AbilityScore.Strength;
                case SkillType.Acrobatics:
                    return AbilityScore.Dexterity;
                case SkillType.SleightOfHand:
                    return AbilityScore.Dexterity;
                case SkillType.Stealth:
                    return AbilityScore.Dexterity;
                case SkillType.Arcana:
                    return AbilityScore.Intelligence;
                case SkillType.History:
                    return AbilityScore.Intelligence;
                case SkillType.Investigation:
                    return AbilityScore.Intelligence;
                case SkillType.Nature:
                    return AbilityScore.Intelligence;
                case SkillType.Religion:
                    return AbilityScore.Intelligence;
                case SkillType.AnimalHandling:
                    return AbilityScore.Wisdom;
                case SkillType.Insight:
                    return AbilityScore.Wisdom;
                case SkillType.Medicine:
                    return AbilityScore.Wisdom;
                case SkillType.Perception:
                    return AbilityScore.Wisdom;
                case SkillType.Survival:
                    return AbilityScore.Wisdom;
                case SkillType.Deception:
                    return AbilityScore.Charisma;
                case SkillType.Intimidation:
                    return AbilityScore.Charisma;
                case SkillType.Performance:
                    return AbilityScore.Charisma;
                case SkillType.Persuation:
                    return AbilityScore.Charisma;
                default:
                    return AbilityScore.None;
            }
        }

    }
}
