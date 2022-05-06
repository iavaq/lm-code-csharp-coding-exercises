using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            return word[0].ToString().ToUpper() + word.Substring(1);
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
            char[] sentenceArray = sentence.ToCharArray();
            Array.Reverse(sentenceArray);
            return new string(sentenceArray);
        }

        public int CountLinuxUsers(List<User> users)
        {
            int linuxUsers = 0;
            foreach (User u in users) {
                if (u.Type == "Linux")
                    linuxUsers++;
            }
            return linuxUsers;
        }
    }
}
