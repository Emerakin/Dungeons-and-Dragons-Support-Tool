namespace BackendLogic.DM
{
    public static class MonsterDataExtender
    {
        public static string SkillTypeToString(this SkillType type)
        {
            switch (type)
            {
                case SkillType.SleightOfHand:
                    return "Sleight of hand";
                case SkillType.AnimalHandling:
                    return "Animal handling";
                default:
                    return type.ToString();
            }
        }

        public static string DamageTypeToString(this DamageType type)
        {
            switch (type)
            {
                case DamageType.Magical:
                    return "Magical weapons";
                case DamageType.Nonmagical:
                    return "Slashing, piercing and bludgeoning from nonmagical weapons";
                case DamageType.Nonsilver:
                    return "Slashing, piercing and bludgeoning from nonsilvered weapons";
                default:
                    return type.ToString();
            }
        }

        public static string AligmentToString(this Aligment aligment)
        {
            switch (aligment)
            {
                case Aligment.LawfulGood:
                    return "Lawful Good";
                case Aligment.NeutralGood:
                    return "Neutral Good";
                case Aligment.ChaoticGood:
                    return "Chaotic Good";
                case Aligment.LawfulNeutral:
                    return "Lawful Neutral";
                case Aligment.TrueNeutral:
                    return "True Neutral";
                case Aligment.ChaoticNeutral:
                    return "Chaotic Neutral";
                case Aligment.LawfulEvil:
                    return "Lawful Evil";
                case Aligment.NeutralEvil:
                    return "Neutral Evil";
                case Aligment.ChaoticEvil:
                    return "Chaotic Evil";
                default:
                    return aligment.ToString();
            }
        }

        public static string LanguageToString(this Language language)
        {
            switch (language)
            {
                case Language.DeepSpeech:
                    return "Deep speech";
                default:
                    return language.ToString();
            }
        }
    }
}
