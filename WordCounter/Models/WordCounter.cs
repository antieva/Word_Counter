using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace WordCounterApp
{
    public class RepeatCounter
    {
        private string _word;
        private string _words;
        private bool _default;

        public RepeatCounter(string myWord, string myWords, bool defaultObject)
        {
            char[] charsToGetRidOf = { '.', ',' ,'!', ' '};
            _word = myWord.Trim(charsToGetRidOf);
            _words = myWords;
            _default = defaultObject;
        }

        public bool GetDefault()
        {
            return _default;
        }

        public string GetWord()
        {
            return _word;
        }
        public void SetWord(string newWord)
        {
            _word = newWord;
        }

        public string GetWords()
        {
            return _words;
        }
        public void SetWords(string newWords)
        {
            _words = newWords;
        }

        public bool IsWordValid()
        {
            string[] separators = {",", ".", "!", "?", ";", ":", " "};
            string[] word = _word.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            if (Regex.IsMatch(_word, "^(?=.*[a-z])") && word.Length == 1) {
                return true;
            }
            return false;
        }

        public bool IsValid()
        {
            if (Regex.IsMatch(_words, "^(?=.*[a-z])")) {
                return true;
            }
            return false;
        }

        public int WordCounter()
        {
            string word = _word.ToLower();
            string words = _words.ToLower();
            string[] separators = {",", ".", "!", "?", ";", ":", " "};
            string[] allWords = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            for (int i = 0; i < allWords.Length; i++) {
                if (word == allWords[i]) {
                    counter++;
                }
            }
            return counter;
        }
    }
}
