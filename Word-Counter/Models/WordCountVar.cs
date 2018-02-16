using System;

namespace Word_Counter.Models
{
    public class RepeatCounter
    {
        private int _wordCount;
        private string _userSentence;
        private string _userWord;
        public int GetWordCount()
        {
            return _wordCount;
        }
        public string GetSentence()
        {
            return _userSentence;
        }
        public string GetWord()
        {
            return _userWord;
        }
        public RepeatCounter(string userSentence, string userWord)
        {
            _wordCount = 0;
            _userSentence = userSentence;
            _userWord = userWord;
            string[] splitSentence = userSentence.Split(' ');
            foreach(var word in splitSentence)
            {
                string newString = word.Trim(new Char[] {'.','?','!'}).ToLower();
                if (userWord.ToLower() == newString)
                {
                    _wordCount++;
                }
            }
        }
    }
}