using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace WordCounterApp
{
    public class RepeatCounter
    {
        private string _word;
        private string _words;

        public RepeatCounter(string myWord, string myWords)
        {
            _word = myWord;
            _words = myWords;
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
            _word = _word.ToLower().Trim();
            _words = _words.ToLower();
            string[] separators = {",", ".", "!", "?", ";", ":", " "};
            string[] words = _words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            for (int i = 0; i < words.Length; i++) {
                if (_word == words[i]) {
                    counter++;
                }
            }
            return counter;
        }
    }
}
