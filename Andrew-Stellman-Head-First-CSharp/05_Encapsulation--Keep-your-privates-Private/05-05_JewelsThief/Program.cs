using System;


namespace _05_05_JewelsThief
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();

            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}
