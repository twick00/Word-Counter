using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word_Counter.Models;

namespace Word_Counter.Test
{
    [TestClass]
    public class WordCountTest
    {
        WordCounter wordCount = new WordCounter{};

        [TestMethod]
        public void CountWord_CountWordThe_True()
        {
            int wordsCounted = wordCount.CountWord("The quick brown fox jumps over a lazy dog", "the");
            Assert.AreEqual(1, wordsCounted);
        }

        [TestMethod]
        public void CountWord_CountWordIs_True()
        {
            int wordsCounted = wordCount.CountWord("Developing webapps is hard. Is it too late to become an Android App Developer?", "is");
            Assert.AreEqual(2, wordsCounted);
        }

        [TestMethod]
        public void CountWord_CountWordIs_False()
        {
            int wordsCounted = wordCount.CountWord("There are zero issues with this sentence.", "is");
            Assert.AreEqual(0, wordsCounted);
        }
    }
}
