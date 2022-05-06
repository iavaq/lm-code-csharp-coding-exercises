using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (String.IsNullOrEmpty(input))
                return false;

            const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
            string text = input.ToLower();
           
           foreach (char letter in Alphabet) { 
                if (text.Contains(letter).Equals(false))
                    return false;                
            }
           
           return true;
        }
    }
}