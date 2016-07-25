using System;


namespace _05_05_JewelsThief
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents)
        {
            Console.WriteLine("Thank you for returning my jewels! " + safeContents.Sparkle());
        }
    }
}
