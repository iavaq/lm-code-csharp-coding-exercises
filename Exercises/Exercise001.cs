using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            return word[0].ToString().ToUpper() + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            return firstName[0].ToString().ToUpper() + "." + lastName[0].ToString().ToUpper();
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            return Math.Round(originalPrice + (originalPrice*(vatRate/100)), 2);
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            char[] sentenceArray = sentence.ToCharArray();
            Array.Reverse(sentenceArray);
            return new string(sentenceArray);
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            int linuxUsers = 0;
            foreach (User u in users) {
                if (u.Type == "Linux")
                    linuxUsers++;
            }
            return linuxUsers;
        }
    }
}
