using System.Windows.Forms;


namespace _05_06_BaseClass_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyBaseClass myBase = new MyBaseClass("Hello, I'm your base class-[baseClassNeedsThis]");
            /*Output: 
            This is the base class: Hello, I'm your base class-[baseClassNeedsThis]
            */

            MySubClass mySub = new MySubClass("Hello, I'm your subclass class-[baseClassNeedsThis]", 42);
            /*Output:
            This is the base class: Hello, I'm your subclass class-[baseClassNeedsThis]
            then another MessageBox
            This is the subclass: Hello, I'm your subclass class-[baseClassNeedsThis] and 42
            */
        }
    }
    class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis)
        {
            MessageBox.Show("This is the base class: " + baseClassNeedsThis);
        }
    }

    class MySubClass : MyBaseClass
    {
        public MySubClass(string baseClassNeedsThis, int anotherValue)
            : base(baseClassNeedsThis)
        {
            MessageBox.Show("This is the subclass: " + baseClassNeedsThis + " and " + anotherValue);
        }
    }
}

