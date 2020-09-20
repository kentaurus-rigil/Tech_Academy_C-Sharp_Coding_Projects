using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of your package:");
            decimal weight = decimal.Parse(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the width of your package:");
                decimal width = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of your package:");
                decimal height = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the length of your package:");
                decimal length = decimal.Parse(Console.ReadLine());

                decimal dimension = width * height * length;
                decimal quote = dimension / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                Console.WriteLine("Thank you for using Package Express.");
            }
            Console.ReadLine();

        }
    }
}
