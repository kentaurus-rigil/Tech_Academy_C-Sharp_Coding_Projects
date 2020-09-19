using System;



    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine(" Person 1 ");
        Console.WriteLine("Please enter your hourly rate:");
        decimal p1HR = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of hours you work per week:");
        decimal p1HW = decimal.Parse(Console.ReadLine());
        decimal total = p1HR * p1HW;
        Console.WriteLine("Your total earned per week =" + total.ToString());
        Console.ReadLine();

        Console.WriteLine(" Person 2 ");
        Console.WriteLine("Please enter your hourly rate:");
        decimal p2HR = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of hours you work per week:");
        decimal p2HW = decimal.Parse(Console.ReadLine());
        decimal total2 = p2HR * p2HW;
        Console.WriteLine("Your total earned per week =" + total2.ToString());
        Console.ReadLine();

        Console.WriteLine(" Annual salary of Person 1 ");
        decimal annualSum = total * 52;
        Console.WriteLine(annualSum);
        Console.ReadLine();

        Console.WriteLine(" Annual salary of Person 2 ");
        decimal annualSum2 = total2 * 52;
        Console.WriteLine(annualSum2);
        Console.ReadLine();

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool trueOrFalse = annualSum > annualSum2;
        Console.Write(trueOrFalse.ToString());
        Console.ReadLine();

    }
}

