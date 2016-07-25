using System;


namespace _05_05_JewelsThief
{
    class JewelThief:Locksmith
    {
        private Jewels stolenJewels = null;
        public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! "+stolenJewels.Sparkle());
        }
    }
}
