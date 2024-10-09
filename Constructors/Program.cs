using System;

namespace Constructors
{
    public class Program
    {
        int i; bool b;
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Value of i is: "+ program.i);    
            Console.WriteLine("Value of b is: "+ program.b);        

            Console.ReadLine();     
        }
    }
}