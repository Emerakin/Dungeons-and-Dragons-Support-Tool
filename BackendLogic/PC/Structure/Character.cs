using System.Collections.Generic;

namespace BackendLogic.PC
{
    // Class representing character used to store data and work in backend
    public class Character
    {
        public string Name { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int TemporaryHp { get; set; }
        public int MaxWeight { get; set; }
        public int CurrentWeight { get; set; }
        public List<int> Money { get; set; }
        public List<Item> Equipment { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Item> Inventory { get; set; }

        public Character()
        {

        }

        public Character(string name, int maxHp, int maxWeight)
        {
            Name = name;
            MaxHp = maxHp;
            MaxWeight = maxWeight;
            CurrentHp = maxHp;
            TemporaryHp = 0;
            CurrentWeight = 0;
            Money = new List<int> { 0, 0, 0, 0, 0};
            Equipment = new List<Item>();
            Spells = new List<Spell>();
            Inventory = new List<Item>();

        }

        public Character(string name, int maxHp, int currentHp, int temporaryHp, int maxWeight, int currentWeight, List<int> money, List<Item> equipment, List<Spell> spells, List<Item> inventory)
        {
            Name = name;
            MaxHp = maxHp;
            CurrentHp = currentHp;
            TemporaryHp = temporaryHp;
            MaxWeight = maxWeight;
            CurrentWeight = currentWeight;
            Money = money;
            Equipment = equipment;
            Spells = spells;
            Inventory = inventory;
        }
    }
}