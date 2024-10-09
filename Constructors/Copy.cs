using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Copy
    {
        int x;
        public Copy(int i)
        {
            x = i;  
        }
        public Copy(Copy obj)
        {
            x=obj.x;        
        }

        public void Display()
        {
            Console.WriteLine("Value of x is: "+ x);    
        }

        static void Main()
        {
            Copy copy = new Copy(12); 
            copy.Display(); 
            Copy copy1 = new Copy(16);  
            Console.ReadLine();     
        }
    }
}
