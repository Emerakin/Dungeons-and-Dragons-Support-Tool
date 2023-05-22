using System;
using System.Collections.Generic;
using System.IO;
using BackendLogic.DM;
using BackendLogic.DatabaseContext.DatabaseContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class DatabaseTests
    {
        private static readonly string[] _monsterPaths = { "..", "..", "..", "BackendLogic", "DatabaseContext", "DatabaseContext", "DB", "Monsters.json" };
        private static readonly string _monsterFilePath = Path.Combine(_monsterPaths);

        [TestMethod]
        public void TestMonstersNullFileNotCreated()
        {
            IEnumerable<Monster> monsters = null;
            File.Delete(_monsterFilePath);
            MonsterDbContext context = new MonsterDbContext();
            try
            {
                Assert.ThrowsException<Exception>(() => context.SaveMonsters(monsters));
            }
            catch (Exception)
            {
                return;
            }
            throw new Exception("context can throw exception");
        }
        
        [TestMethod]
        public void TestMonstersNullFileCreatedWithCorrectPermissions()
        {
            IEnumerable<Monster> monsters = null;
            File.Delete(_monsterFilePath);
            File.Create(_monsterFilePath).Close();
            MonsterDbContext context = new MonsterDbContext();
            try
            {
                Assert.ThrowsException<Exception>(() => context.SaveMonsters(monsters));
            }
            catch (Exception)
            {
                return;
            }
            throw new Exception("context can throw exception");
        }

        [TestMethod]
        public void TestMonstersNullFileCreatedWithIncorrectPermissions()
        {
            IEnumerable<Monster> monsters = null;
            File.Delete(_monsterFilePath);
            File.Create(_monsterFilePath).Close();
            File.SetAttributes(_monsterFilePath, FileAttributes.ReadOnly);
            MonsterDbContext context = new MonsterDbContext();
            try
            {
                Assert.ThrowsException<Exception>(() => context.SaveMonsters(monsters));
            }
            catch (Exception)
            {
                File.SetAttributes(_monsterFilePath, FileAttributes.Normal);
                return;
            }
            File.SetAttributes(_monsterFilePath, FileAttributes.Normal);
            throw new Exception("context can throw exception");
        }
        
        [TestMethod]
        public void TestMonstersEmptyFileNotCreated()
        {
            IEnumerable<Monster> monsters = new List<Monster>();
            File.Delete(_monsterFilePath);
            MonsterDbContext context = new MonsterDbContext();
            try
            {
                Assert.ThrowsException<Exception>(() => context.SaveMonsters(monsters));
            }
            catch (Exception)
            {
                return;
            }
            throw new Exception("context can throw exception");
        }
        
        [TestMethod]
        public void TestMonstersEmptyFileCreatedWithCorrectPermissions()
        {
            IEnumerable<Monster> monsters = new List<Monster>();
            File.Delete(_monsterFilePath);
            File.Create(_monsterFilePath).Close();
            MonsterDbContext context = new MonsterDbContext();
            try
            {
                Assert.ThrowsException<Exception>(() => context.SaveMonsters(monsters));
            }
            catch (Exception)
            {
                return;
            }
            throw new Exception("context can throw exception");
        }

        [TestMethod]
        public void TestMonstersEmptyFileCreatedWithIncorrectPermissions()
        {
            IEnumerable<Monster> monsters = new List<Monster>();
            File.Delete(_monsterFilePath);
            File.Create(_monsterFilePath).Close();
            File.SetAttributes(_monsterFilePath, FileAttributes.ReadOnly);
            MonsterDbContext context = new MonsterDbContext();
            try
            {
                Assert.ThrowsException<Exception>(() => context.SaveMonsters(monsters));
            }
            catch (Exception)
            {
                File.SetAttributes(_monsterFilePath, FileAttributes.Normal);
                return;
            }
            File.SetAttributes(_monsterFilePath, FileAttributes.Normal);
            throw new Exception("context can throw exception");
        }

        [TestMethod]
        public void TestMonstersNotEmptyFileNotCreated()
        {
            BasicInformation info = new BasicInformation();
            info.Name = "name";
            info.Aligment = Aligment.Any;
            info.Size = Size.Medium;
            info.Type = BackendLogic.DM.Type.Fey;
            info.HitDice = 4;
            info.DiceCount = 2;
            info.Hp = 5;
            info.ArmorClass = 20;
            info.ChallangeRating = 5;
            info.ProficiencyBonus = 5;
            DamageTypeModifiers mods = new DamageTypeModifiers();
            mods.DamageTypeResistances = new List<DamageType>();
            mods.DamageTypeVulnerabilities = new List<DamageType>();
            mods.DamageTypeImmunities = new List<DamageType>();
            IEnumerable<Monster> monsters = new List<Monster>
            {
                new Monster(info, new List<Tuple<MovementSpeedType, int>>(), new Dictionary<AbilityScore, Tuple<int, int>>(), new List<AbilityScore>(),
                new List<Skill>(), mods, new List<Condition>(), new List<Tuple<Sense, int>>(), new List<Language>(), 0, new List<Trait>(), new List<BackendLogic.DM.Action>())
            };
            File.Delete(_monsterFilePath);
            MonsterDbContext context = new MonsterDbContext();
            try
            {
                Assert.ThrowsException<Exception>(() => context.SaveMonsters(monsters));
            }
            catch (Exception)
            {
                return;
            }
            throw new Exception("context can throw exception");
        }

        [TestMethod]
        public void TestMonstersNotEmptyFileCreatedWithCorrectPermissions()
        {
            BasicInformation info = new BasicInformation();
            info.Name = "name";
            info.Aligment = Aligment.Any;
            info.Size = Size.Medium;
            info.Type = BackendLogic.DM.Type.Fey;
            info.HitDice = 4;
            info.DiceCount = 2;
            info.Hp = 5;
            info.ArmorClass = 20;
            info.ChallangeRating = 5;
            info.ProficiencyBonus = 5;
            DamageTypeModifiers mods = new DamageTypeModifiers();
            mods.DamageTypeResistances = new List<DamageType>();
            mods.DamageTypeVulnerabilities = new List<DamageType>();
            mods.DamageTypeImmunities = new List<DamageType>();
            IEnumerable<Monster> monsters = new List<Monster>
            {
                new Monster(info, new List<Tuple<MovementSpeedType, int>>(), new Dictionary<AbilityScore, Tuple<int, int>>(), new List<AbilityScore>(),
                new List<Skill>(), mods, new List<Condition>(), new List<Tuple<Sense, int>>(), new List<Language>(), 0, new List<Trait>(), new List<BackendLogic.DM.Action>())
            };
            File.Delete(_monsterFilePath);
            File.Create(_monsterFilePath).Close();
            MonsterDbContext context = new MonsterDbContext();
            try
            {
                Assert.ThrowsException<Exception>(() => context.SaveMonsters(monsters));
            }   
            catch (Exception)
            {
                return;
            }
            throw new Exception("context can throw exception");
        }

        [TestMethod]
        public void TestMonstersNotEmptyFileCreatedWithIncorrectPermissions()
        {
            BasicInformation info = new BasicInformation();
            info.Name = "name";
            info.Aligment = Aligment.Any;
            info.Size = Size.Medium;
            info.Type = BackendLogic.DM.Type.Fey;
            info.HitDice = 4;
            info.DiceCount = 2;
            info.Hp = 5;
            info.ArmorClass = 20;
            info.ChallangeRating = 5;
            info.ProficiencyBonus = 5;
            DamageTypeModifiers mods = new DamageTypeModifiers();
            mods.DamageTypeResistances = new List<DamageType>();
            mods.DamageTypeVulnerabilities = new List<DamageType>();
            mods.DamageTypeImmunities = new List<DamageType>();
            IEnumerable<Monster> monsters = new List<Monster>
            {
                new Monster(info, new List<Tuple<MovementSpeedType, int>>(), new Dictionary<AbilityScore, Tuple<int, int>>(), new List<AbilityScore>(),
                new List<Skill>(), mods, new List<Condition>(), new List<Tuple<Sense, int>>(), new List<Language>(), 0, new List<Trait>(), new List<BackendLogic.DM.Action>())
            };
            File.Delete(_monsterFilePath);
            File.Create(_monsterFilePath).Close();
            File.SetAttributes(_monsterFilePath, FileAttributes.ReadOnly);
            MonsterDbContext context = new MonsterDbContext();
            try
            {
                Assert.ThrowsException<Exception>(() => context.SaveMonsters(monsters));
            }
            catch (Exception)
            {
                File.SetAttributes(_monsterFilePath, FileAttributes.Normal);
                return;
            }
            File.SetAttributes(_monsterFilePath, FileAttributes.Normal);
            throw new Exception("context can throw exception");
        }
    }
}
