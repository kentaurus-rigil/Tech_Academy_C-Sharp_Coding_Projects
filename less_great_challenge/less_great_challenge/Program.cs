using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_great_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 12;
            int num3 = 2;
            int num4 = 8;

            if (num1 <= num2 && num4 >= num3)
            {
                Console.WriteLine("The if statement ran.");
            }
            else
            {
                Console.WriteLine("The else statement ran.");
            }
            Console.ReadLine();





            //Console.WriteLine("Lesser Than Operator");
            //int age = 20;
           
            //if (age <= 20)
            //{
            //    Console.WriteLine("No you may not purchase that bottle of wine.");
            //}
            //else
            //{
            //    Console.WriteLine("There you go!");
            //}

            //Console.WriteLine("Greater Than Operator");
            //int age1 = 25;


            //if (age1 >= 25)
            //{
            //    Console.WriteLine("Yes, you may rent a car from us.");
            //}
            //else
            //{
            //    Console.WriteLine("No, you may not rent a car from us.");
            //}
            //Console.ReadLine();
        }
    }
}
