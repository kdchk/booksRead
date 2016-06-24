using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseTheDebugger__ConsoleApp_
{
    class Loops
    {
        public static void Looping()
        {
            Console.WriteLine("Looping");
            WhileLoop();
            ForLoop();

        }

        private static void ForLoop()
        {
            Console.WriteLine("----for-----");
            int count = 0;
            for (int i = 0; i < 8; i = i + 2)
            {
                count++;
                Console.WriteLine($"Count {count} times");
            }
        }

        private static void WhileLoop()
        {
            Console.WriteLine("----while---");
            int x = 12;
            while (x > 5)
            {
                //x = x - 3;
                //or
                x -= 3;
                Console.WriteLine(x);
               
            }
        }
    }
}
