using System;
using System.Linq;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        { 
            if (String.IsNullOrEmpty(input))
                return false;

            const string Alphabet = "abcdefghijklmnopqrstuvwxyz";

            //refactoring feedback, imported System.Linq, to use:
            return Alphabet.All(letter => input.ToLower().Contains(letter));
           
            /*original submission:
            string text = input.ToLower();

            foreach (char letter in Alphabet) { 
                if (text.Contains(letter).Equals(false))
                    return false;                
            }
           
           return true;
           */
        }
    }
}