using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace WordCounterApp
{
    public class RepeatCounter
    {
        public static int WordCounter(string myString, string myWord)
        {
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
