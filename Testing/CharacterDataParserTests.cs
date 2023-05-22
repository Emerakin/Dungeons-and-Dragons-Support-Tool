using System.Collections.Generic;
using BackendLogic.PC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class CharacterDataParserTests
    {
        [TestMethod]
        public void TestParseItemCostWithNull()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost(null);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestParseItemCostWithEmptyString()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("");
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestParseItemCostWithIncorrectFormat()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("1 marka");
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatAndSmallLetters()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("1 gp");
            List<int> expected = new List<int> { 0, 1, 0, 0, 0};
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatFirstLetterSmallSecondCapital()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("1 gP");
            List<int> expected = new List<int> { 0, 1, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatFirstLetterCapitalSecondSmall()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("1 Gp");
            List<int> expected = new List<int> { 0, 1, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatAndCapitalLetters()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("1 GP");
            List<int> expected = new List<int> { 0, 1, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatAndMoreCurrencyTypes()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("1 gp 5 cp");
            List<int> expected = new List<int> { 0, 1, 0, 0, 5 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithIncorrectFormatAndMoreCurrencyType()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("1gp 1pp");
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatZeroCost()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("0 gp");
            List<int> expected = new List<int> { 0, 0, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithStringSayingFree()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("Free");
            List<int> expected = new List<int> { 0, 0, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithStringSayingfree()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("free");
            List<int> expected = new List<int> { 0, 0, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatMoreCurrencyTypesAllZeroCost()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("0 pp 0 gp 0 ep 0 sp 0 cp");
            List<int> expected = new List<int> { 0, 0, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatMoreCurrencyTypesSomeZeroCost()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("1 pp 0 gp 0 ep 1 sp 0 cp");
            List<int> expected = new List<int> { 1, 0, 0, 1, 0 };
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatNegativeCost()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("-5 gp");
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatMoreCurrencyTypesAllNegativeCost()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("-5 pp -4 gp -3 ep -2 sp -1 cp");
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestParseItemCostWithCorrectFormatMoreCurrencyTypesSomeNegativeCostSomeZeroCost()
        {
            CharacterDataParser parser = new CharacterDataParser();
            var result = parser.ParseItemCost("-5 pp 0 gp -3 ep 0 sp -1 cp");
            Assert.IsNull(result);
        }
    }
}
