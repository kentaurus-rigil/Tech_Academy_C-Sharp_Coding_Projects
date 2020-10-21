using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace dateAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is: ");
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            DateTime newTime = currentTime.AddHours(userNum);
            Console.WriteLine(newTime);
            Console.ReadLine();
                
        }
    }
}
