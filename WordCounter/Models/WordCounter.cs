using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace WordCounterApp
{
    public class RepeatCounter
    {
        public static bool IsValid(string myString)
        {
            if (Regex.IsMatch(myString, "^(?=.*[a-z])") || !String.IsNullOrEmpty(myString)) {
                return true;
            }
            return false;
        }

        public static int WordCounter(string myString, string myWord)
        {
            myString = myString.ToLower();
            myWord = myWord.ToLower();
            string[] separators = {",", ".", "!", "?", ";", ":", " "};
            string[] words = myString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            for (int i = 0; i < words.Length; i++) {
                if (myWord == words[i]) {
                    counter++;
                }
            }
            return counter;
        }
    }
}
