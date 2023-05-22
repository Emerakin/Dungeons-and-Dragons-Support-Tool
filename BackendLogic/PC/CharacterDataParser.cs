using System.Collections.Generic;

namespace BackendLogic.PC
{
    // Class to parse user input connected with character
    public class CharacterDataParser
    {
        public CharacterDataParser()
        {

        }

        // Method to parse string representing SpellLevel enum to SpellLevel enum
        public SpellLevel ParseStringToSpellLevel(string spellLevel)
        {
            switch (spellLevel)
            {
                case "Cantrip":
                    return SpellLevel.Cantrip;
                case "1st":
                    return SpellLevel.First;
                case "2nd":
                    return SpellLevel.Second;
                case "3rd":
                    return SpellLevel.Third;
                case "4th":
                    return SpellLevel.Fourth;
                case "5th":
                    return SpellLevel.Fifth;
                case "6th":
                    return SpellLevel.Sixth;
                case "7th":
                    return SpellLevel.Seventh;
                case "8th":
                    return SpellLevel.Eighth;
                case "9th":
                    return SpellLevel.Ninth;
                default:
                    return SpellLevel.None;
            }
        }

        // Method to parse string representing SpellSchool enum to SpellSchool enum
        public SpellSchool ParseStringToSpellSchool(string spellSchool)
        {
            switch (spellSchool)
            {
                case "Abjuration":
                    return SpellSchool.Abjuration;
                case "Conjuration":
                    return SpellSchool.Conjuration;
                case "Divination":
                    return SpellSchool.Divination;
                case "Enchantment":
                    return SpellSchool.Enchantment;
                case "Evocation":
                    return SpellSchool.Evocation;
                case "Illusion":
                    return SpellSchool.Illusion;
                case "Necromancy":
                    return SpellSchool.Necromancy;
                case "Transmutation":
                    return SpellSchool.Transmutation;
                default:
                    return SpellSchool.None;
            }
        }

        // Method to parse string representing money type/currency to index in list representing total money
        private int ParseMoneyTypeIndex(string type)
        {
            switch (type.ToLower())
            {
                case "pp":
                    return 0;
                case "gp":
                    return 1;
                case "ep":
                    return 2;
                case "sp":
                    return 3;
                case "cp":
                    return 4;
                default:
                    return -1;
            }
        }

        // Method to parse string representign item cost to a list
        public List<int> ParseItemCost(string cost)
        {
            if (cost == null || cost == "")
            {
                return null;
            }
            if (cost == "Free" || cost == "free")
            {
                return new List<int> { 0, 0, 0, 0, 0};
            }
            string[] parts = cost.Split();
            if (parts.Length % 2 != 0)
            {
                return null;
            }
            var result = new List<int> { 0, 0, 0, 0, 0 };
            for (int i = 0; i < parts.Length; i += 2)
            {
                int singleCost;
                if (!int.TryParse(parts[i], out singleCost))
                {
                    return null;
                }
                if (singleCost < 0)
                {
                    return null;
                }
                int index = ParseMoneyTypeIndex(parts[i + 1]);
                if (index < 0)
                {
                    return null;
                }
                result[index] = singleCost;
            }
            return result;
        }
    }
}