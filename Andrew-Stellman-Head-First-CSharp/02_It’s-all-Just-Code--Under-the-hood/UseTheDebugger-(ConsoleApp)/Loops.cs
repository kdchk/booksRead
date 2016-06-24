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

        }

        private static void WhileLoop()
        {
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
