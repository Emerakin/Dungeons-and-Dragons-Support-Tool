using BackendLogic.DM;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class BasicInformationStructCreatingTests
    {
        [TestMethod]
        public void TestHitDiceNullDiceCountCorrectConModZero()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", null, "5", 0));
        }

        [TestMethod]
        public void TestHitDiceCorrectDiceCountNullConModZero()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D4", null, 0));
        }

        [TestMethod]
        public void TestHitDiceEmptyDiceCountCorrectConModZero()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "", "5", 0));
        }

        [TestMethod]
        public void TestHitDiceCorrectDiceCountEmptyConModZero()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D4", "", 0));
        }

        [TestMethod]
        public void TestHitDiceCorrectLowValueDiceCountNumberConModZero()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            var result = obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D4", "5", 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(((BasicInformation)result).HitDice, 4);
            Assert.AreEqual(((BasicInformation)result).DiceCount, 5);
            Assert.AreEqual(((BasicInformation)result).Hp, 12);
        }

        [TestMethod]
        public void TestHitDiceCorrectLowValueDiceCountNumberConModPositiveNumber()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNotNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D4", "5", 5));
        }

        [TestMethod]
        public void TestHitDiceCorrectLowValueDiceCountNumberConModNegativeNumber()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D4", "5", -5));
        }

        [TestMethod]
        public void TestHitDiceCorrectHighValueDiceCountNumberConModZero()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNotNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D20", "5", 0));
        }

        [TestMethod]
        public void TestHitDiceCorrectHighValueDiceCountNumberConModPositiveNumber()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNotNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D20", "5", 5));
        }

        [TestMethod]
        public void TestHitDiceCorrectHighValueDiceCountNumberConModNegativeNumber()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNotNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D20", "5", -5));
        }

        [TestMethod]
        public void TestHitDiceIncorrectDiceCountCorrectConModZero()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D5", "5", 0));
        }

        [TestMethod]
        public void TestHitDiceCorrectDiceCountNotNumberConModZero()
        {
            MonsterCommandExecutor executor = new MonsterCommandExecutor();
            PrivateObject obj = new PrivateObject(executor);
            Assert.IsNull(obj.Invoke("CreateBasicInformation", "name", "20", "8", "Chaotic Good", "Tiny", "Fey", "D4", "abba", 0));
        }
    }
}
