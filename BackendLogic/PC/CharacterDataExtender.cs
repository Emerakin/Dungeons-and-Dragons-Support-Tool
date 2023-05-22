namespace BackendLogic.PC
{
    // Static class for extending methods converting enums in player role part to a readable state
    public static class CharacterDataExtender
    {
        // Static method to convert SpellLevel enum to readable/preferable state
        public static string SpellLevelToString(this SpellLevel spellLevel)
        {
            switch (spellLevel)
            {
                case SpellLevel.Cantrip:
                    return "Cantrip";
                case SpellLevel.First:
                    return "1st level";
                case SpellLevel.Second:
                    return "2nd level";
                case SpellLevel.Third:
                    return "3rd level";
                case SpellLevel.Fourth:
                    return "4th level";
                case SpellLevel.Fifth:
                    return "5th level";
                case SpellLevel.Sixth:
                    return "6th level";
                case SpellLevel.Seventh:
                    return "7th level";
                case SpellLevel.Eighth:
                    return "8th level";
                case SpellLevel.Ninth:
                    return "9th level";
                default:
                    return "";
            }
        }

        // Static method to convert SpellLevel enum to readable/preferable state
        public static string SpellSchoolToString(this SpellSchool spellSchool)
        {
            switch (spellSchool)
            {
                case SpellSchool.Abjuration:
                    return "Abjuration";
                case SpellSchool.Conjuration:
                    return "Conjuration";
                case SpellSchool.Divination:
                    return "Divination";
                case SpellSchool.Enchantment:
                    return "Enchantment";
                case SpellSchool.Evocation:
                    return "Evocation";
                case SpellSchool.Illusion:
                    return "Illusion";
                case SpellSchool.Necromancy:
                    return "Necromancy";
                case SpellSchool.Transmutation:
                    return "Transmutation";
                default:
                    return "";
            }
        }
    }
}
