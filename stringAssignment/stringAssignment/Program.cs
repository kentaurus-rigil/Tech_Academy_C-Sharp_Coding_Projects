using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //An efficient concatenation.
            //string userName = "<Type your name here>";
            //string date = DateTime.Today.ToShortDateString();

            //string str = $"Hello {userName}.  Today is {date}.";

            //Concatenate three strings for the assignment.
            string text = "Star" +" "+ "Healani" +" "+ "Erickson";
            System.Console.WriteLine(text);
            Console.ReadLine();


            //Converts a string to uppercase.
            string name = "Star";
            name = name.ToUpper(); //Can also ToLower();
            Console.WriteLine(name);
            Console.ReadLine();


            
            StringBuilder sb = new StringBuilder();
            sb.Append("Gardner \n");
            sb.Append("We gave you a chance \n");
            sb.Append("To water the plants.\n");
            sb.Append("We didn't mean that way-\n");
            sb.Append("Now zip up your pants.\n");
            sb.Append("By Shel Silverstein");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
