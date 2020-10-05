using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {

        List<int> integers = new List<int>() { 100, 107, 220, 56, 72, 99, 338 };
        try
        {
            Console.WriteLine("Pick a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            foreach (int item in integers)
            {

                int result = item / userInput;
                Console.WriteLine("Press 'Enter' to see the result for the next integer in the array divided by your number.");
                Console.ReadLine();
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }

        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message); //or ("Please type a whole number")

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

