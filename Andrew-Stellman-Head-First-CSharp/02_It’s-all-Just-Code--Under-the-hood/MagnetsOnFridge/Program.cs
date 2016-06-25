using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnetsOnFridge
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVariant();   //OK: a-b c-d
            BookVariant(); //OK: a-b c-d

            Console.ReadLine();

        }

        private static void BookVariant()
        {
            string result = "";
            int x = 3;

            while (x > 0)
            {
                if (x > 2)
                {
                    result += "a";
                }

                x -= 1;
                result += "-";

                if (x == 2)
                {
                    result += "b c";
                }

                if (x == 1)
                {
                    result += "d";
                    x -= 1;
                }
            }
            Console.WriteLine(result);
        }

        private static void MyVariant()
        {
            string result = "";
            int x = 3;

            if (x > 2)
            {
                result += "a";
            }
            while (x > 0)
            {
                x -= 1;
                result += "-";

                if (x == 2)
                {
                    result += "b c";
                }

                if (x == 1)
                {
                    result += "d";
                    x -= 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
