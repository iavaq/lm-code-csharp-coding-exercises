using System;
using System.Collections.Generic;
using Exercises.Models;
using System.Linq;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return firstName[0].ToString().ToUpper() + "." + lastName[0].ToString().ToUpper();
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            return Math.Round(originalPrice * (1 + (vatRate/100)), 2);
        }

        public string Reverse(string sentence)
        {
            //implementing refactoring feedback using ternary operator:
            return string.IsNullOrEmpty(sentence) ?
                 sentence : new string(sentence.Reverse().ToArray());
           
            /* orginal submission:
            char[] sentenceArray = sentence.ToCharArray();
            Array.Reverse(sentenceArray);
            return new string(sentenceArray);
            */
     
        }

        public int CountLinuxUsers(List<User> users)
        {
            //implementing refactoring feedback using ternary operator:
            return users.Where(u => u.Type == "Linux").Count();

            /* original submission:
            int linuxUsers = 0;
            foreach (User u in users) {
                if (u.Type == "Linux")
                    linuxUsers++;
            }
            return linuxUsers;
            */
         }         
    }
}
