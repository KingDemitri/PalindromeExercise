using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise;
public class WordSmith
{
       public bool IsAPalindrome(string word)
        {
            string reverseWord = "";
            
            for (int i = word.Length-1; i >= 0; i--)
            {
            reverseWord += word[i];
            }
        return (reverseWord.ToLower() == word.ToLower());


            //if (reverseWord == word)
            //{
            //    return true;
            //}
            //else
            //{ 
            //return false;
            //}
        {
    }
}
}