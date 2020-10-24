using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int age = 0;
            try
            {
                Console.WriteLine("Please type your age.");
                age = Convert.ToInt32(Console.ReadLine());

                if (age == 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    DateTime current = DateTime.Now;
                    int birthYear = current.Year - age;
                    Console.WriteLine("Your birth year is: " + birthYear);
                }
                Console.ReadLine();

            }

            catch (ArgumentException)
            {
                Console.WriteLine("You may not enter zero for your age.");
                Console.ReadLine();   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
            

        }
    }
}








