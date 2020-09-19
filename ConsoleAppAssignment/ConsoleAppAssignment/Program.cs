using System;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)

        {


            Console.WriteLine("Enter a number:");
            long number = Convert.ToInt64(Console.ReadLine());
            long total = number * 50;
            Console.WriteLine("Your number multiplied by 50 =" + total.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int total1 = number1 + 25;
            Console.WriteLine("Your number plus 25 =" + total1.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            double number2 = Convert.ToInt32(Console.ReadLine());
            double total2 = number2 / 12.5;
            Console.WriteLine("Your number divided by 12.5 =" + total2.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            double number3 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = number3 > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            double number4 = Convert.ToInt32(Console.ReadLine());
            double remainder = number4 % 7;
            Console.WriteLine("Your number divided by seven has a remainder of: " + remainder);
            Console.ReadLine();

        }
    }
}
    

