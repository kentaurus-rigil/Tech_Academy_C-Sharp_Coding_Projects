using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment224
{
    static class Class1
    {
        public static void method(int x)
        {
            int operation = x / 2;
            Console.WriteLine(operation);
            Console.ReadLine();
        }

        public static void method(out int num1, out int num2)
        {
            num1 = 15;
            num2 = 45;
            int result = num1 + num2;
            Console.WriteLine("The value of the two numbers is: " + result);

        }
    }
}
