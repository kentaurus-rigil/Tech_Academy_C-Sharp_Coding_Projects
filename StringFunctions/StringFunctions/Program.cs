using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            name = "Joe";  //doesn't change the string it creates a new string.  Too many can slow down the system.
            //Can use string builders to dynamically change the string
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jesse");

            //Functions With Strings:

            //string name = "Star";
            //string quote = "The man said, \"Hello\", Star. \n \\Hello on a new line. \n \t Hello on a tab.";
            //string fileName = "C:\\Users\\Jesse";
            //string fileName2 = @"C:\Users\Jesee";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");
            //Console.WriteLine(trueOrFalse);

            //int length = name.Length;
            //Console.WriteLine(length);

            //name = name.ToUpper(); //Can also ToLower();
            //Console.WriteLine(name);



            //Console.WriteLine(quote);
            //Console.ReadLine();
        }
    }
}
