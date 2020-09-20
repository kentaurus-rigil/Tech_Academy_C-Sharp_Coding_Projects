using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");

            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Have you ever had a DUI? Write \"true\" if you have had a DUI or \"false\" if you haven't.");
            bool dui = bool.Parse(Console.ReadLine());
            

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool qualified = age > 15 && dui == false && tickets <= 3;
            Console.Write(qualified);
            Console.ReadLine();







            //Console.WriteLine(" Annual salary of Person 1 ");
            //decimal annualSum = total * 52;
            //Console.WriteLine(annualSum);
            //Console.ReadLine();

            //Console.WriteLine(" Annual salary of Person 2 ");
            //decimal annualSum2 = total2 * 52;
            //Console.WriteLine(annualSum2);
            //Console.ReadLine();

            //Console.WriteLine("Does Person 1 make more money than Person 2?");
            //bool trueOrFalse = annualSum > annualSum2;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();
        }
    }
}
