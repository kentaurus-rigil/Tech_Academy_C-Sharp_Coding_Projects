using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userNum = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\guesttta\Documents\GitHub\Tech_Academy_C-Sharp_Coding_Projects\SWAssignment.txt", true))
            {
                file.WriteLine(userNum);
            }
            Console.ReadLine();

        }
    }
}
