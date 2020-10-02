using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            ////Part 1-3
            string[] feels = { "I love:", "I hate:", "I like:", "I despise:" };
            Console.WriteLine("What is something you love and hate?");
            string userInput = Console.ReadLine();

            //for (int f = 0; f < feels.Length; f++)
            for (int f = 0; f <= 3; f++)
            {
                feels[f] += userInput;
                Console.WriteLine(feels[f]);
            }

            Console.ReadLine();

            //Part 4
            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };
            Console.WriteLine("Type Jesse, Erik, Adam, or Daniel to find it's index in the list.");
            string findName = Console.ReadLine();


            foreach (string name in names)
            {
                if (names.Contains(findName))
                {
                    if (findName == name)
                    {
                        Console.WriteLine(names.IndexOf(name));
                    }
                    else
                    {
                        Console.WriteLine("An Error has occurred.  Please try typing a name from the list again.");
                    }  //Don't understand step 5 or how to do it. Need to adjust code, so it doesn't show all the elements.
                }
            }
            Console.ReadLine();

            //Part 5
            List<string> students = new List<string>() { "Olivia", "Emma", "Ava", "Sophia", "Amelia", "Ava", "Mia" };
            Console.WriteLine("Type the name Ava to find the match.");

            string findMatch = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                if (students.Contains(findMatch))
                {
                    if (students[i] == findMatch)
                    {
                        Console.WriteLine("Index of " + findMatch + " is " + i);
                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.WriteLine(findMatch + " is not the index " + i);
                }
            }


            //Part 6
            List<string> classmates = new List<string>() { "Olivia", "Emma", "Ava", "Sophia", "Amelia", "Ava", "Mia" };
            List<string> newStudent = new List<string>() { };
            foreach (string items in students)
            {
                if (!newStudent.Contains(items))
                {
                    newStudent.Add(items);
                    Console.WriteLine(items);
                }
                else
                {
                    Console.WriteLine(items + " This item is already on the list.");
                }
            }
            Console.ReadLine();

                






        }
    }
}


            
            




                    ////This is an integer array
                    //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

                    //   // In the for loop we set the conditions.i = 0(where the loop starts);
                    //    //i < testScores.Length(how long it runs); i++(how many loops);
                    //    for (int i = 0; i < testScores.Length; i++)
                    //        //Below is what you want the loop to do
                    //    {   //[i] is the item greater than 85 do this.
                    //        if (testScores[i] > 85)
                    //        {
                    //            Console.WriteLine("Passing test score: " + testScores[i]);
                    //        }
                    //    }

                    //                    Console.ReadLine();



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

                    

                    //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
                    //List<int> passingScores = new List<int>();

                    //foreach (int score in testScores)
                    //{
                    //    if (score > 85)
                    //    {
                    //        passingScores.Add(score);
                    //    }
                    //}
                    //Console.WriteLine(passingScores.Count);//Count is the same as Length in array.  It writes the number of elements in the List.
                    //Console.ReadLine();

               // }
       // }
   // }

    


