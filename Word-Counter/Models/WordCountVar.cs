using System;

namespace Word_Counter.Models
{
    public class RepeatCounter
    {
        public int CountWord(string userSentence, string countThis)
        {
            int countNum = 0;
            string[] splitSentence = userSentence.Split(' ');
            foreach(var word in splitSentence)
            {
                string newString = word.Trim(new Char[] {'.','?','!'}).ToLower();
                if (countThis == newString)
                {
                    countNum++;
                }
            }
            return countNum;
        }
    }
}