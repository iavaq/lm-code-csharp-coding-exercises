using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string text = input.ToLower();

            if (input != null)
            {
                foreach (char c in alphabet)
                    if (text.Contains(c)==false)
                        return false;
                return true;
            }
            else
                return false;
        }
    }
}
