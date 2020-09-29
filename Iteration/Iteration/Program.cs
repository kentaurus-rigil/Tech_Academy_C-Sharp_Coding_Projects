using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {   //This is an integer array
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //In the for loop we set the conditions. i = 0(where the loop starts); 
            //i < testScores.Length(how long it runs); i++(how many loops);
            //for (int i = 0; i < testScores.Length; i++)
            //Below is what you want the loop to do
            //{   //[i] is the item greater than 85 do this.
            //if (testScores[i] > 85)
            // {
            // Console.WriteLine("Passing test score: " + testScores[i]);
            //                }
            //            }
            //            Console.ReadLine();

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            ////iterate over the array
            ////j starts at 0; j runs for as many times as there are elements in the array(while j is less than length);
            ////j++(after each j loop add one)
            //for (int j = 0; j < names.Length; j++)
            //{
            //    //if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);//to see all the elements of the array.
            //    }
            //    Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(98);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    //if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);//only this line if you want all the elements in the array to print
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);//Count is the same as Length in array.  It writes the number of elements in the List.
            Console.ReadLine();

        }
       }
   }

