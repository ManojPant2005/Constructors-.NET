using System;

namespace Constructors
{
    public class Parameterized
    {
        int x;
        public Parameterized(int i)
        {
            Console.WriteLine("Parameterized Constructor is called." + i);
        }

        public void Display()
        {
            Console.WriteLine("Value of x is :" + x);
        }

        static void Main()
        {
            Parameterized parameterized = new Parameterized(10);
            Parameterized parameterized1 = new Parameterized(20);
            parameterized.Display();   
            parameterized1.Display();       
            Console.ReadLine();     

        }
    }
}
