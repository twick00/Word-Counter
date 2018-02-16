using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word_Counter.Models;

namespace Word_Counter.Test
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void CountWord_CountWordThe_One()
        {
            RepeatCounter wordCount = new RepeatCounter("The quick brown fox jumps over a lazy dog","the");
            Assert.AreEqual(1, wordCount.GetWordCount());
        }

        [TestMethod]
        public void CountWord_CountWordIs_Two()
        {
            RepeatCounter wordCount = new RepeatCounter("Developing webapps is hard. Is it too late to become an Android App Developer?", "is");
            Assert.AreEqual(2, wordCount.GetWordCount());
        }

        [TestMethod]
        public void CountWord_CountWordIs_Zero()
        {
            RepeatCounter wordCount = new RepeatCounter("There are zero issues with this sentence.", "is");
            Assert.AreEqual(0, wordCount.GetWordCount());
        }
    }
}
