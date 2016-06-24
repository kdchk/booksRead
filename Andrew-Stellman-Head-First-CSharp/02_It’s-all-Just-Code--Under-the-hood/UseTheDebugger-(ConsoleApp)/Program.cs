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
            //LearnToDebug();
            Loops.Looping();

            //--------Delay--------
            Console.ReadKey();
        }

        private static void LearnToDebug()
        {
            int number = 15; //15        
            number = number + 10; //25
            number = 36 * 10; //360
            number = 12 - (42 / 7);//6
            number += 10; //16
            number *= 3; //48
            number = 71 / 3; //23

            int count = 0; Console.WriteLine(count); //0
            count++; Console.WriteLine(count); //1
            count--; Console.WriteLine(count); //0

            string result = "hello";
            Console.WriteLine(result += " again " + result); //hello again hello
            Console.WriteLine(result = "the value of counter is: " + count);//the value of counter is: 0
            Console.WriteLine(result = "");//

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
            Console.WriteLine(yesNo);//false
            Console.WriteLine(anotherBool);//true
        }
    }
}
