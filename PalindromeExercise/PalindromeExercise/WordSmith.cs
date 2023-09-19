using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            string reverseWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];

            }

            if( word == reverseWord )
            {
                return true;
            }
            return false;

        }

    }
    
}
