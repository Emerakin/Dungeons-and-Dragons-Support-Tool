using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendLogic.DatabaseContext;

namespace BackendLogic.DM
{
    public class MonsterCommandExecutor
    {
        private MonsterDataParser _parser;
        private MonsterService _service;
        private List<Task> _tasks;

        public MonsterCommandExecutor() : this(new MonsterService(), new MonsterDataParser())
        {

        }

        public MonsterCommandExecutor(MonsterService service, MonsterDataParser parser)
        {
            _service = service;
            _parser = parser;
            _tasks = new List<Task>();
        }

        public void AddMonster(Monster newMonster)
        {
            _service.AddMonster(newMonster);
        }

        public void RemoveMonster(Monster monster)
        {
            _service.RemoveMonster(monster);
        }

        public void SaveMonsters()
        {
            _tasks.Add(_service.SaveMonsters());
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

        public async Task AwaitTasks()
        {
            SaveMonsters();
            await Task.WhenAll(_tasks);
        }

        public void UpdateMonster(Monster originalMonster, Monster newMonster)
        {
            originalMonster.Info = newMonster.Info;
            originalMonster.MovementSpeed = newMonster.MovementSpeed;
            originalMonster.AbilityScores = newMonster.AbilityScores;
            originalMonster.SavingThrows = newMonster.SavingThrows;
            originalMonster.Skills = newMonster.Skills;
            originalMonster.DamageTypeModifiers = newMonster.DamageTypeModifiers;
            originalMonster.ConditionImmunities = newMonster.ConditionImmunities;
            originalMonster.Senses = newMonster.Senses;
            originalMonster.Languages = newMonster.Languages;
            originalMonster.Telepathy = newMonster.Telepathy;
            originalMonster.Actions = newMonster.Actions;
            originalMonster.Traits = newMonster.Traits;
        }

        public List<Monster> GetMonsters()
        {
            return _service.GetMonsters();
        }

        private BasicInformation? CreateBasicInformation(string name, string ac, string cr, string aligment, string size,
            string type, string hitDice, string diceCount, int conMod)
        {    
            if (name == null || ac == null || cr == null || aligment ==null || size == null || type == null || type == null || hitDice == null || diceCount == null)
            {
                return null;
            }
            BasicInformation basicInformation = new BasicInformation();
            basicInformation.Name = name;
            basicInformation.ArmorClass = int.Parse(ac);
            basicInformation.ChallangeRating = _parser.ParseStringToChallangeRating(cr);
            if (basicInformation.ChallangeRating < 0)
            {
                return null;
            }
            if (basicInformation.ChallangeRating <= 1)
            {
                basicInformation.ProficiencyBonus = 2;
            }
            else
            {
                basicInformation.ProficiencyBonus = ((int)basicInformation.ChallangeRating - 1) / 4 + 2;
            }
            basicInformation.Aligment = _parser.ParseStringToAligment(aligment);
            basicInformation.Size = _parser.ParseStringToSize(size);
            basicInformation.Type = _parser.ParseStringToType(type);
            if (basicInformation.Aligment == Aligment.None || basicInformation.Size == Size.None || basicInformation.Type == Type.None)
            {
                return null;
            }
            basicInformation.HitDice = _parser.ParseStringToHitDice(hitDice);
            if (basicInformation.HitDice < 0)
            {
                return null;
            }
            int parsedDiceCount;
            if (!int.TryParse(diceCount, out parsedDiceCount))
            {
                return null;
            }
            basicInformation.DiceCount = parsedDiceCount;
            float hpPerDice = basicInformation.HitDice / 2 + 0.5f;
            basicInformation.Hp = (int)Math.Floor((hpPerDice + conMod) * basicInformation.DiceCount);
            if (basicInformation.Hp <= 0)
            {
                return null;
            }
            return basicInformation;
        }

        private Dictionary<AbilityScore, Tuple<int, int>> CreateAbilityScores(IEnumerable<string> abilityScores)
        {
            int idx = 0;
            Dictionary<AbilityScore, Tuple<int, int>> result = new Dictionary<AbilityScore, Tuple<int, int>>();
            foreach (string abilityScore in abilityScores)
            {
                int value = int.Parse(abilityScore);
                result.Add((AbilityScore)idx, new Tuple<int, int>(value, (value - 10) / 2));
                idx++;
            }
            return result;
        }

        private List<Tuple<MovementSpeedType, int>> CreateMovementSpeeds(IEnumerable<string> movements)
        {
            int idx = 0;
            List<Tuple<MovementSpeedType, int>> result = new List<Tuple<MovementSpeedType, int>>();
            bool zeroWalk = false;
            foreach (string speed in movements)
            {
                if (speed == "")
                {
                    idx++;
                    continue;
                }
                int value = int.Parse(speed);
                if ((MovementSpeedType)idx == MovementSpeedType.Walk && value == 0)
                {
                    zeroWalk = true;
                }
                if ((value > 0) || ((MovementSpeedType)idx == MovementSpeedType.Walk))
                {
                    result.Add(new Tuple<MovementSpeedType, int>((MovementSpeedType)idx, value));
                }
                idx++;
            }
            if (zeroWalk)
            {
                if (result.Count() >= 2)
                {
                    return result;
                }
                return null;
            }
            return result;
        }

        private List<Skill> CreateSkills(IEnumerable<bool> skillProficiencies, IEnumerable<bool> skillExpertise)
        {
            List<Skill> result = new List<Skill>();
            for (int idx = 0; idx < skillProficiencies.Count(); idx++)
            {
                Skill skill= new Skill();
                SkillType type = (SkillType)idx;
                skill.Type = type;
                skill.Modifier = _parser.GetSkillModifier(type);
                if (skillExpertise.ElementAt(idx))
                {
                    skill.ProficiencyType = ProficiencyType.Expertise;
                    result.Add(skill);
                }
                else if (skillProficiencies.ElementAt(idx))
                {
                    skill.ProficiencyType = ProficiencyType.Proficiency;
                    result.Add(skill);
                }
            }
            return result;
        }

        private List<Condition> CreateConditionImmunities(IEnumerable<bool> conditions)
        {
            List<Condition> result = new List<Condition>();
            for (int idx = 0; idx < conditions.Count(); idx++)
            {
                if (conditions.ElementAt(idx))
                {
                    result.Add((Condition)idx);
                }
            }
            return result;
        }

        private List<Language> CreateLanguages(IEnumerable<bool> languages, int telepathy)
        {
            List<Language> result = new List<Language>();
            for (int idx = 0; idx < languages.Count() - 1; idx++)
            {
                if (languages.ElementAt(idx))
                {
                    result.Add((Language)idx);
                }
            }
            if (languages.Last() && telepathy > 0)
            {
                result.Add(Language.Telepathy);
            }
            return result;
        }

        private DamageTypeModifiers CreateDamageTypeModifiers(IEnumerable<bool> damageTypeVulnerabilities,
                                                              IEnumerable<bool> damageTypeResistances,
                                                              IEnumerable<bool> damageTypeImmuntiies)
        {
            DamageTypeModifiers result = new DamageTypeModifiers();
            List<DamageType> vulnerabilities = new List<DamageType>();
            List<DamageType> resistances = new List<DamageType>();
            List<DamageType> immunities = new List<DamageType>();
            for (int idx = 0; idx < damageTypeVulnerabilities.Count(); idx++)
            {
                DamageType type = (DamageType)idx;
                if (damageTypeVulnerabilities.ElementAt(idx))
                {
                    vulnerabilities.Add(type);
                }
                if (damageTypeResistances.ElementAt(idx))
                {
                    resistances.Add(type);
                }
                if (damageTypeImmuntiies.ElementAt(idx))
                {
                    immunities.Add(type);
                }
            }
            result.DamageTypeVulnerabilities = vulnerabilities;
            result.DamageTypeResistances = resistances;
            result.DamageTypeImmunities = immunities;
            return result;
        }

        private List<Tuple<Sense, int>> CreateSenses(IEnumerable<string> senses)
        {
            List<Tuple<Sense, int>> result = new List<Tuple<Sense, int>>();
            for (int idx = 0; idx < senses.Count(); idx++)
            {
                string sense = senses.ElementAt(idx);
                if (sense == "")
                {
                    continue;
                }
                int value = int.Parse(senses.ElementAt(idx));
                if (value > 0)
                {
                    result.Add(new Tuple<Sense, int>((Sense)idx, value));
                }
            }
            return result;
        }

        private List<AbilityScore> CreateSavingThrows(IEnumerable<bool> savingThrowProficiencies)
        {
            List<AbilityScore> result = new List<AbilityScore>();
            for (int idx = 0; idx < savingThrowProficiencies.Count(); idx++)
            {
                if (savingThrowProficiencies.ElementAt(idx))
                {
                    result.Add((AbilityScore)idx);
                }
            }
            return result;
        }

        public Monster CreateMonster(string name, string ac, string cr, string aligment, string size, string type, string hitDice,
            string diceCount, IEnumerable<string> abilityScores, IEnumerable<bool> conditionImmunities, IEnumerable<string> movementSpeeds,
            IEnumerable<bool> languages, IEnumerable<bool> skillProficiencies, IEnumerable<bool> skillExpertise, IEnumerable<string> senses,
            IEnumerable<bool> savingThrowProficiencies, IEnumerable<bool> damageTypeVulnerabilities, IEnumerable<bool> damageTypeResistances,
            IEnumerable<bool> damageTypeImmuntiies, string telepathy, IEnumerable<Tuple<string, string>> traits, IEnumerable<Tuple<string, string>> actions)
        {
            if (name == "" || ac == "" || cr == "" || aligment == "" || size == "" || type == "" || hitDice == "" || diceCount == ""
                || abilityScores.Any(abilityScore => abilityScore == "") || movementSpeeds.ElementAt(0) == "")
            {
                return null;
            }
            Dictionary<AbilityScore, Tuple<int, int>> parsedAbilityScores = CreateAbilityScores(abilityScores);
            BasicInformation? basicInformation = CreateBasicInformation(name, ac, cr, aligment, size, type, hitDice,
                                                                        diceCount, parsedAbilityScores[AbilityScore.Constitution].Item1);
            if (basicInformation == null)
            {
                return null;
            }
            int telepathyRange = telepathy == "" ? 0 : int.Parse(telepathy);
            List<Tuple<MovementSpeedType, int>> movement = CreateMovementSpeeds(movementSpeeds);
            if (movement == null)
            {
                return null;
            }
            List<AbilityScore> savingThrows = CreateSavingThrows(savingThrowProficiencies);
            List<Skill> skills = CreateSkills(skillProficiencies, skillExpertise);
            DamageTypeModifiers damageTypeModifiers = CreateDamageTypeModifiers(damageTypeVulnerabilities, damageTypeResistances, damageTypeImmuntiies);
            List<Condition> parsedConditionsImmunities = CreateConditionImmunities(conditionImmunities);
            List<Tuple<Sense, int>> parsedSenses = CreateSenses(senses);
            List<Language> parsedLanguages = CreateLanguages(languages, telepathyRange);
            List<Trait> parsedTraits = traits.Select(nameDescription => new Trait(nameDescription.Item1, nameDescription.Item2)).ToList();
            List<Action> parsedActions = actions.Select(nameDescription => new Action(nameDescription.Item1, nameDescription.Item2)).ToList();
            return new Monster((BasicInformation)basicInformation, movement, parsedAbilityScores, savingThrows, skills, damageTypeModifiers,
                parsedConditionsImmunities, parsedSenses, parsedLanguages, telepathyRange, parsedTraits, parsedActions);
        }

        public Aligment ParseAligment(string aligment)
        {
            return _parser.ParseStringToAligment(aligment);
        }

        public Size ParseSize(string size)
        {
            return _parser.ParseStringToSize(size);
        }

        public Type ParseType(string type)
        {
            return _parser.ParseStringToType(type);
        }
    }
}
