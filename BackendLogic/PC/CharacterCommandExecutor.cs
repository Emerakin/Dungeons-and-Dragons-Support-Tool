using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendLogic.DatabaseContext;

namespace BackendLogic.PC
{
    // Class to execute backend logic of user actions
    public class CharacterCommandExecutor
    {
        private readonly CharacterService _service;
        private readonly CharacterDataParser _parser;
        private List<Task> _tasks;

        public CharacterCommandExecutor(CharacterService service, CharacterDataParser parser)
        {
            _service = service;
            _parser = parser;
            _tasks = new List<Task>();
        }

        public CharacterCommandExecutor() : this(new CharacterService(), new CharacterDataParser())
        {

        }

        public async Task AwaitTasks()
        {
            SaveCharacters();
            await Task.WhenAll(_tasks);
        }

        // Parse user input and create a blank Character object
        public Character CreateCharacter(string name, string maxHp, string maxWeight)
        {
            if (name == "" || maxHp == "" || maxWeight == "")
            {
                return null;
            }
            int maxHitPoints = int.Parse(maxHp);
            int maxCarryWeight = int.Parse(maxWeight);
            if (maxCarryWeight % 15 != 0)
            {
                return null;
            }
            return new Character(name, maxHitPoints, maxCarryWeight);
        }

        // Add character to database
        public void AddCharacter(Character newCharacter)
        {
            _service.AddCharacter(newCharacter);
        }

        // Remove character from database
        public void RemoveCharacter(Character character)
        {
            _service.RemoveCharacter(character);
        }

        // Save (write) characters to file
        public void SaveCharacters()
        {
            _tasks.Add(_service.SaveCharacters());
            var toRemove = new List<Task>();
            foreach (Task task in _tasks)
            {
                if (task.IsCompleted)
                {
                    toRemove.Add(task);
                }
            }
            foreach (Task task in toRemove)
            {
                _tasks.Remove(task);
            }
        }

        // Get all characters from database
        public List<Character> GetCharacters()
        {
            return _service.GetCharacters();
        }

        // Increase or decrease value of certain type (currency) of a character
        public void ChangeCharacterMoney(Character character, int index, bool inc)
        {
            if (character == null || index < 0 || index > 4)
            {
                return;
            }
            if (inc)
            {
                character.Money[index]++;
            }
            else
            {
                character.Money[index]--;
                if (character.Money[index] < 0)
                {
                    character.Money[index] = 0;
                }
            }
        }

        // Increase or decrease maximum carry capacity of a character
        public void ChangeCharacterMaxWeight(Character character, bool inc)
        {
            if (character == null)
            {
                return;
            }
            if (inc)
            {
                character.MaxWeight += 15;
            }
            else
            {
                character.MaxWeight -= 15;
                if (character.MaxWeight < 0)
                {
                    character.MaxWeight = 0;
                }
            }
        }

        // Increase or decrease maximum hit points of a character
        public void ChangeMaxCharacterHp(Character character, string hp, bool inc)
        {
            if (character == null || hp == "")
            {
                return;
            }
            if (inc)
            {
                character.MaxHp += int.Parse(hp);
                character.CurrentHp += int.Parse(hp);
            }
            else
            {
                character.MaxHp -= int.Parse(hp);
                character.CurrentHp -= int.Parse(hp);
                if (character.MaxHp < 0)
                {
                    character.MaxHp = 0;
                }
            }
        }

        // Increase current hit points of a character
        public void HealCharacter(Character character, string hp)
        {
            if (character == null || hp == "")
            {
                return;
            }
            int value = int.Parse(hp);
            character.CurrentHp += value;
            if (character.CurrentHp > character.MaxHp)
            {
                character.CurrentHp = character.MaxHp;
            }

        }

        // Decrease current hit points of a character
        public void DamageCharacter(Character character, string hp)
        {
            if (character == null || hp == "")
            {
                return;
            }
            int value = int.Parse(hp);
            if (value > character.TemporaryHp)
            {
                value -= character.TemporaryHp;
                character.TemporaryHp = 0;
                character.CurrentHp -= value;
                if (character.CurrentHp < 0)
                {
                    character.CurrentHp = 0;
                }
            }
            else
            {
                character.TemporaryHp -= value;
            }
        }

        // Overwrite temporary hit points of a character
        public void SetCharacterTemporaryHp(Character character, string hp)
        {
            if (character == null || hp == "")
            {
                return;
            }
            character.TemporaryHp = int.Parse(hp);
        }

        // Add item to character's inventory
        public Item AddCharacterItem(Character character, string name, string category, string cost, string weight, string description)
        {
            if (character == null || name == "" || category == "" || cost == "" || weight == "" || category == "All")
            {
                return null;
            }
            List<int> itemCost = _parser.ParseItemCost(cost);
            if (itemCost == null)
            {
                return null;
            }
            var item = new Item(name, category, itemCost, int.Parse(weight), description);
            character.Inventory.Add(item);
            character.CurrentWeight += item.Weight;
            return item;
        }

        // Edit item in character's inventory
        public bool EditCharacterItem(Character character, Item item, string name, string category, string cost, string weight, string description)
        {
            if (character == null || item == null || name == "" || category == "" || weight == "" || category == "All")
            {
                return false;
            }
            List<int> itemCost = _parser.ParseItemCost(cost);
            if (itemCost == null)
            {
                return false;
            }
            character.CurrentWeight -= item.Weight;
            item.Name = name;
            item.Category = category;
            item.Cost = itemCost;
            item.Weight = int.Parse(weight);
            item.Description = description;
            character.CurrentWeight += item.Weight;
            return true;
        }

        // Get categories of all items in character invenotry
        public List<string> GetItemCategories(Character character)
        {
            return character.Inventory
                .Select(item => item.Category)
                .Union(character.Equipment
                    .Select(item => item.Category))
                .Distinct()
                .ToList();
        }

        // Move item from character's inventory to their equipment
        public void EquipItem(Character character, Item item)
        {
            item.Equipped = true;
            character.Equipment.Add(item);
            character.Inventory.Remove(item);
        }

        // Move item from character's equipment to their inventory
        public void UnequipItem(Character character, Item item)
        {
            item.Equipped = false;
            character.Equipment.Remove(item);
            character.Inventory.Add(item);
        }

        // Add spell to character's spell list
        public Spell AddCharacterSpell(Character character, string name, string level, string school, string range, bool componentV,
            bool componentS, bool componentM, string castingTime, string duration, bool concetration, bool ritual, string description)
        {
            if (character == null || name == "" || range == "" || castingTime == "" || duration == "")
            {
                return null;
            }
            var spell = new Spell(name, _parser.ParseStringToSpellLevel(level), _parser.ParseStringToSpellSchool(school), range,
                new Tuple<bool, bool, bool>(componentV, componentS, componentM), castingTime, duration, concetration, ritual, description);
            character.Spells.Add(spell);
            return spell;
        }

        // Edit spell in character's spell list
        public bool EditCharacterSpell(Character character, Spell spell, string name, string level, string school, string range, bool componentV,
            bool componentS, bool componentM, string castingTime, string duration, bool concetration, bool ritual, string description)
        {
            if (character == null || spell == null || name == "" || range == "" || castingTime == "" || duration == "")
            {
                return false;
            }
            spell.Name = name;
            spell.Level = _parser.ParseStringToSpellLevel(level);
            spell.School = _parser.ParseStringToSpellSchool(school);
            spell.Range = range;
            spell.Componenets = new Tuple<bool, bool, bool>(componentV, componentS, componentM);
            spell.CastingTime = castingTime;
            spell.Duration = duration;
            spell.Concentration = concetration;
            spell.Ritual = ritual;
            spell.Description = description;
            return true;
        }

        public SpellLevel ParseSpellLevel(string spellLevel)
        {
            return _parser.ParseStringToSpellLevel(spellLevel);
        }

        public SpellSchool ParseSpellSchool(string spellSchool)
        {
            return _parser.ParseStringToSpellSchool(spellSchool);
        }
    }
}