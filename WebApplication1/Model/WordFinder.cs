﻿using System;
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
            string[] words = description.Split(_separatingChars, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
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