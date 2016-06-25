using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseTheDebugger__ConsoleApp_
{
    class if_else_statements
    {
        public static void IfElse()
        {
            Console.WriteLine("----if-else statements----");
            TryIfElse();

        }

        private static void TryIfElse()
        {
            string message = "";
            int someValue = 0;
            Console.Write("Enter some int type value: ");
            someValue = Int32.Parse(Console.ReadLine());
            if (someValue == 24)
            {
                Console.WriteLine(message="Value is 24. Yeah!");
            }
            else
            {
                Console.WriteLine(message="Value is NOT 24. =(");
            }
        }
    }
}
