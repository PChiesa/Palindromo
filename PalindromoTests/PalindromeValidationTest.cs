using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromo;

namespace PalindromoTests
{
    [TestClass]
    public class PalindromeValidationTest
    {
        private ValidateWord validateWord;

        [TestInitialize]
        public void Init()
        {
            validateWord = new ValidateWord();
        }

        [TestMethod]
        public void ShouldBePalindromeEvenWordLength()
        {
            bool result = validateWord.IsPalindrome("Osso");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldBePalindromeOddWordLength()
        {
            bool result = validateWord.IsPalindrome("Radar");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotBePalindromeEvenWordLength()
        {
            bool result = validateWord.IsPalindrome("Ossada");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldNotBePalindromeOddWordLength()
        {
            bool result = validateWord.IsPalindrome("Radares");
            Assert.IsFalse(result);
        }
    }
}
