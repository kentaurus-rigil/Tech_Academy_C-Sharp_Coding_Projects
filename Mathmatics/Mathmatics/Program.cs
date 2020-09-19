using System;


    class Program
    {
        static void Main()
        {
        //int total3 = 5 + 10;
        //Console.WriteLine("Five plus Ten = " + total3.ToString());
        //Console.ReadLine();

        //int total3 = 5 + 10;
        //int otherTotal = 12 + 22;
        //int combined = total3 + otherTotal;
        //Console.WriteLine(combined);
        //Console.ReadLine();

        //int difference = 10 - 5;
        //Console.WriteLine("Ten minus Five = " + difference.ToString());
        //Console.ReadLine();

        //int product3 = 10 * 5;
        //Console.WriteLine(product3);
        //Console.ReadLine();

        //int quotient = 100 / 5;
        //Console.WriteLine(quotient);
        //Console.ReadLine();

        //Int is not able to write decimals, so when the number requires decimal use double
        //double quotient = 100.0 / 17.0;
        //Console.WriteLine(quotient);
        //Console.ReadLine();

        //% is a modulus that determines the remainder 10/2 = 5 with no remainders
        //int remainder = 10 % 2;
        //Console.WriteLine(remainder);
        //Console.ReadLine();

        //bool trueOrFalse = 12 < 5;
        //Console.Write(trueOrFalse.ToString());
        //Console.ReadLine();

        //int roomTemperature = 70;
        //int currentTemperature = 72;

        //bool isWarm = currentTemperature > roomTemperature;
        //Console.WriteLine(isWarm);
        //Console.ReadLine();

        int roomTemperature = 70;
        int currentTemperature = 72;

        //bool isWarm = currentTemperature < roomTemperature;
        //bool isWarm = currentTemperature <= roomTemperature;
        bool isWarm = currentTemperature != roomTemperature; //Does current temp not equal room temp

        Console.WriteLine(isWarm);
        Console.ReadLine();

        //11/2 does not divide equally, so the remainder will be 1
        //int remainder = 11 % 2;
        //Console.WriteLine(remainder);
        //Console.ReadLine();

        int num1 = 5;
        int num2 = 7;
        int total = num1 + num2;
        Console.WriteLine(total);
        Console.ReadLine();

        int num3 = 5;
        int num4 = 7;
        int total2 = num4 - num3;
        Console.WriteLine(total2);
        Console.ReadLine();

        int num5 = 5;
        int num6 = 7;
        int product = num5 * num6;
        Console.WriteLine(product);
        Console.ReadLine();

        int num7 = 35;
        int num8 = 5;
        int product2 = num7 / num8;
        Console.WriteLine(product2);
        Console.ReadLine();

        string firstName = "Star";
        string lastName = "Erickson";
        Console.WriteLine(firstName + lastName);










        Console.ReadLine();
        }
    }

