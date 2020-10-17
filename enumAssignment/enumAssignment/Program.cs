using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryIt = true;
            while (tryIt)
            {
                try
                {


                    Console.WriteLine("Please enter the current day of the week.");
                    string weekDay = Console.ReadLine();
                    DaysOfTheWeek userDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), weekDay, true);
                    Console.WriteLine("The day of the week is" + userDay + ".");
                    Console.ReadLine();
                    tryIt = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message); //or ("")
                                                   //return; (stops the operation.
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't divide by zero."); //(ex.Message)
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }

           public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    
        
}
}
        