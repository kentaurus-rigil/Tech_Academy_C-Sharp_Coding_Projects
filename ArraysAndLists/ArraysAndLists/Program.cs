using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //List very common and most used feature
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);
        Console.WriteLine(intList[0]);
        Console.ReadLine();


        //String List
        List<string> intList2 = new List<string>();
        intList2.Add("Hello");
        intList2.Add("Star");
        intList2.Remove("Star");
        Console.WriteLine(intList2[0]);
        Console.ReadLine();


        //Use an array for a fixed quantity, because difficult to change
        //Intialize an array
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;
        //Console.WriteLine(numArray[3]);

        ////Intialized the same array, but more efficiently
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
        //Console.WriteLine(numArray1[3]);

        ////Instance of an array the most efficient way
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        ////To change an item in the array identify its index number and write the new item.
        //numArray2[5] = 650;
        //Console.WriteLine(numArray2[5]);



        //Use for a very large quantity (e.g. byteArray)
        //byte[] byteArray = new int[5];






        Console.ReadLine();

        }
    }

