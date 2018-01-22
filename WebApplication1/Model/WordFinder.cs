using System;
namespace WebApplication1.Model
{
    public class WordFinder
    {
        private string[] _separatingChars = { ".", ",", ":", ";", " ", "'" };

        public WordFinder()
        {

        }

        public WordFinder(string[] separatingChars)
        {
            _separatingChars = separatingChars;
        }

        public int Find(string keyword, string description)
        {
            int count = 0;
            if (description == null)
                return count;
            string[] words = description.Split(_separatingChars, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word == keyword)
                {
                    count += 1;
                    break;
                }
            }
            return count;
        }
    }
}
