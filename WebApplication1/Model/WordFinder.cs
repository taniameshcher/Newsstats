using System;
namespace WebApplication1.Model
{
    public class WordFinder
    {
        private string[] _separatingChars = { ".", ",", ":", ";", " ", "'", "-" };

        public WordFinder()
        {

        }

        public WordFinder(string[] separatingChars)
        {
            _separatingChars = separatingChars;
        }

        /// <summary>
        /// Searches for keyword in description
        /// </summary>
        /// <param name="keyword">Keyword string</param>
        /// <param name="description">Description sentences</param>
        /// <returns>Number of keywords found in description</returns>
        public int Find(string keyword, string description)
        {
            int count = 0;
            if (string.IsNullOrWhiteSpace(description))
                return count;
            if (string.IsNullOrWhiteSpace(keyword))
            {
                throw new Exception("There is no keyword to search");
            }
            keyword = keyword.ToLower();
            description = description.ToLower();
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
