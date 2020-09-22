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
            //Concatenate three strings.
            string userName = "<Type your name here>";
            string date = DateTime.Today.ToShortDateString();

            string str = $"Hello {userName}.  Today is {date}.";
            System.Console.WriteLine(str);
            Console.ReadLine();


            //Converts a string to uppercase.
            string name = "Star";
            name = name.ToUpper(); //Can also ToLower();
            Console.WriteLine(name);
            Console.ReadLine();


            //Stringbuilder creates a paragrph of text, one sentence at a time.
            string names = "Gardner";
            names = "Gardner";  //doesn't change the string it creates a new string.  Too many can slow down the system.
            //Can use string builders to dynamically change the string
            StringBuilder sb = new StringBuilder();
            sb.Append("Gardner" + "\n We gave you a chance" + "\n To water the plants." + "\n We didn't mean that way-" + "\n Now zip up your pants." + "\n By Shel Silverstein");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
