using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {

        //Part 1 Array of strings and part 3 display when user selects an index that doesn't exist.
        
        string[] stringArray = new string[6];
        stringArray[0] = "As I see it, yes.";
        stringArray[1] = "Don't count on it.";
        stringArray[2] = "It is decidedly so.";
        stringArray[3] = "It is certain.";
        stringArray[4] = "Outlook not so good.";
        stringArray[5] = "My sources say no.";
        Console.WriteLine("Think of a \'yes\' or \'no\' question. Then type a number between 0-5 to receive your answer.");
        int index = Convert.ToInt32(Console.ReadLine());
        if(index > 5 || index < 0)
        {
            Console.WriteLine("Your index selection is not between 0-5.");
        }
        else
        {
            Console.WriteLine("Answer:" + stringArray[index]);
            
        }
        Console.ReadLine();


        //Part 2 Array of integers and part 3 display when user selects an index that doesn't exist.
        int[] numArray = { 23, 10, 105, 700, 5050, 900, 23 };
        Console.WriteLine("Type a number between 0-6 to see data for that index.");
        int index1 = Convert.ToInt32(Console.ReadLine());
        if (index1 > 6 || index1 < 0)
        {
            Console.WriteLine("Your index selection is not between 0-5.");
        }
        else
        {
            Console.WriteLine(numArray[index1]);

        }
        Console.ReadLine();



        //Part 4
        List<string> intList = new List<string>();
        intList.Add("Hawaii");
        intList.Add("Alaska");
        intList.Add("California");
        intList.Add("New York");
        intList.Add("Oregon");
        intList.Add("Florida");
        Console.WriteLine("Type a number between 0-5 to see a state in the index.");
        int index2 = Convert.ToInt32(Console.ReadLine());
        if (index2 > 5 || index2 < 0)
        {
            Console.WriteLine("Your index selection is not between 0-5.");
        }
        else
        {
            Console.WriteLine("The State:" + intList[index2]);

        }

        Console.ReadLine();

    }
}
          