using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment224
{
    class Program
    {
        static public void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Class1.method(num1);
            Console.ReadLine();

            int x, y;           
            Class1.method(out x, out y);
            Console.ReadLine();

        }
    }
}



