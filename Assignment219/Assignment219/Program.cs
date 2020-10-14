using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment219
{
    class Program
    {
            
            static void Main(string[] args)
            {
            Class1 ObjOne = new Class1();
                int myNum1 = ObjOne.method(100);
                double myNum2 = ObjOne.method(4.3, 6.26);
                int myNum3 = ObjOne.method("200", "100");
                Console.WriteLine("Int: " + myNum1);
                Console.WriteLine("Double: " + myNum2);
                Console.WriteLine("String: " + myNum3);
                Console.ReadLine();
        }
    }
}





//Console.WriteLine("Enter a number.");
//            int numOne = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(ObjOne.methodOne(numOne));
//            Console.ReadLine();
//        }
//Class1 ObjOne = new Class1();
//int numTwo = Convert.ToInt32(Console.ReadLine());
//Console.Writeline(ObjOne.methodOne(numTwo));
