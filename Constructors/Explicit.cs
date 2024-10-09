
using System;

namespace Constructors
{
    class Explicit
    {
        public Explicit()
        {
            Console.WriteLine("Constructor is called.");
        }
        static void Main()
        {
            Explicit ex = new Explicit();        

            Console.ReadLine();     
        }
    }
}
