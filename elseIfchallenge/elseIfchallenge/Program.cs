using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elseIfchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Video Example step 176
            int currentTemperature = 70;
            int roomTemperature = 70;

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("Room temperature is warmer than current temperature.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }
            Console.ReadLine();
            //Console.WriteLine("Is your name Jesse, Brett, Adam or other?");
            //string name = Console.ReadLine();

            //if (name == "Jesse")
            //{
            //    Console.WriteLine("Your name is Jesse");
            //    Console.ReadLine();
            //}
            //else if (name != "Jesse")
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //    Console.ReadLine();
            //}
            //else if (name == "Adam")
            //{
            //    Console.WriteLine("Your name is Adam");
            //    Console.ReadLine();
            //}
            //else if (name == "other")
            //{
            //    Console.WriteLine("What is your name?");
            //    string yourName = Console.ReadLine();
            //    Console.WriteLine("Welcome:" + yourName);
            //    Console.ReadLine();
            //}
        }
    }
}
