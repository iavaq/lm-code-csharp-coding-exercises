using System;
namespace Exercises
{
    public class Exercise003
    {
        // Replace the exception statement below with your code!
        public string[] IceCreamFlavours => //throw new NotImplementedException();
            new string[] {"Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet"};

        // Replace the exception statement below with your code!
        public int IceCreamCode(string iceCreamFlavour) => //throw new NotImplementedException();
            Array.IndexOf(IceCreamFlavours, iceCreamFlavour);
    }
}
