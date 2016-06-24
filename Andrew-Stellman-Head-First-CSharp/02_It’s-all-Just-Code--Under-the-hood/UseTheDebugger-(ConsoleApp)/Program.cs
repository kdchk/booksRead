using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseTheDebugger__ConsoleApp_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15; //15        
            n = n + 10; //25
            n = 36 * 10; //360
            n = 12 - (42 / 7);//6
            n += 10; //16
            n *= 3; //48
            n = 71 / 3; //23

            int c = 0;      Console.WriteLine(c); //0
            c++;            Console.WriteLine(c); //1
            c--;            Console.WriteLine(c); //0

            string r = "hello";
            Console.WriteLine(r+=" again "+r); //hello again hello
            Console.WriteLine(r = "the value of counter is: " + c);//the value of counter is: 0
            Console.WriteLine(r="");//

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
            Console.WriteLine(yesNo);//false
            Console.WriteLine(anotherBool);//true

            //--------Delay--------
            Console.ReadKey();
        }

    }
}
