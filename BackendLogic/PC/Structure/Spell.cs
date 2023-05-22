using System;
using System.Collections.Generic;
using System.Linq;

namespace BackendLogic.PC
{
    // Class representing spell used to store data and work in backend
    public class Spell
    {
        public string Name { get; set; }
        public SpellLevel Level { get; set; }
        public SpellSchool School { get; set; }
        public string Range { get; set; }
        public Tuple<bool, bool, bool> Componenets { get; set; }
        public string CastingTime { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public bool Concentration { get; set; }
        public bool Ritual { get; set; }

        public Spell(string name, SpellLevel level, SpellSchool school, string range, Tuple<bool, bool, bool> componenets,
            string castingTime, string duration, bool concentration, bool ritual, string description)
        {
            Name = name;
            Level = level;
            School = school;
            Range = range;
            Componenets = componenets;
            CastingTime = castingTime;
            Duration = duration;
            Description = description;
            Concentration = concentration;
            Ritual = ritual;
        }

        public string ComponentsToString()
        {
            var components = new List<string>();
            if (Componenets.Item1)
            {
                components.Add("V");
            }
            if (Componenets.Item2)
            {
                components.Add("S");
            }
            if (Componenets.Item3)
            {
                components.Add("M");
            }
            if (components.Count == 0)
            {
                return "";
            }
            return components.Aggregate((c1, c2) => string.Join(" ", c1, c2));
        }
    }
}