using AlphabetAndNumbers.Utils;
using NUnit.Framework;

namespace AlphabetAndNumbersTest
{
    public class StringToIntTest
    {
        [Test]
        public void ExpectedOutputTest1()
        {
            string input = "hello 45";
            string expectedOutput = "85121215 45";
            var result = StringToInt.StringChallenge(input);

            Assert.AreEqual(result, expectedOutput);
        }

        [Test]
        public void ExpectedOutputTest2()
        {
            string input = "jaj-a";
            string expectedOutput = "10110-1";
            var result = StringToInt.StringChallenge(input);

            Assert.AreEqual(result, expectedOutput);
        }

        [Test]
        public void ExpectedOutputTest3()
        {
            string input = "af5c a#!";
            string expectedOutput = "1653 1#!";
            var result = StringToInt.StringChallenge(input);

            Assert.AreEqual(result, expectedOutput);
        }
    }
}