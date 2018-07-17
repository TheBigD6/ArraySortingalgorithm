using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomClass = new Random();
            Console.WriteLine("Would you like to use the bubble sort or ArrayList Sort? A/B");
            string userChoice = Console.ReadLine();
            //Array sorting algorithm
            if (userChoice.ToLower().Equals("a"))
            {
                do
                {

                    ArrayList numbersArray = new ArrayList();
                    numbersArray.Add(RandomClass.Next(1, 49));//1
                    numbersArray.Add(RandomClass.Next(1, 49));//2
                    numbersArray.Add(RandomClass.Next(1, 49));//3
                    numbersArray.Add(RandomClass.Next(1, 49));//4
                    numbersArray.Add(RandomClass.Next(1, 49));//5
                    numbersArray.Add(RandomClass.Next(1, 49));//6
                    PrintValues(numbersArray);
                    Console.WriteLine("Would you like the numbers to be sorted(Sort&Reverse Method) in accending or decending? A/D");
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower().Equals("a"))
                    {
                        numbersArray.Sort();
                        PrintValues(numbersArray);
                    }
                    else if (userInput.ToLower().Equals("d"))
                    {
                        numbersArray.Reverse();
                        PrintValues(numbersArray);
                    }
                    Console.WriteLine("Would you like to use the bubble sort or ArrayList Sort? A/B");
                    userChoice = Console.ReadLine();
                } while (userChoice.ToLower().Equals("a"));
            }

            //Bubble sort algorithm
            else if (userChoice.ToLower().Equals("b"))
            {
                do
                {
                    int[] something = new int[6] { RandomClass.Next(1, 49),
                                           RandomClass.Next(1, 49),
                                           RandomClass.Next(1, 49),
                                           RandomClass.Next(1, 49),
                                           RandomClass.Next(1, 49),
                                           RandomClass.Next(1, 49),};
                    Console.WriteLine("Would you like to see the ranom array?Y/N");
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower().Equals("y"))
                    {
                        PrintValues(something);
                    }
                    Console.WriteLine("Would you like the array to be sorted in Acending/Decending? A/D");
                    userInput = Console.ReadLine();
                    if (userInput.ToLower().Equals("a"))
                    {
                        int temp = 0;
                        for (int i = 0; i < something.Length; i++)
                        {
                            for (int j = 0; j < something.Length; j++)
                            {
                                if (something[i] < something[j])
                                {
                                    temp = something[i];

                                    something[i] = something[j];

                                    something[j] = temp;
                                }
                            }
                        }
                        PrintValues(something);
                    }
                    else if (userInput.ToLower().Equals("d"))
                    {
                        int temp = 0;
                        for (int i = 0; i < something.Length; i++)
                        {
                            for (int j = 0; j < something.Length; j++)
                            {
                                if (something[j] < something[i])
                                {
                                    temp = something[i];

                                    something[i] = something[j];

                                    something[j] = temp;
                                }
                            }
                        }
                        PrintValues(something);
                    }

                    Console.WriteLine("Would you like to use the bubble sort or ArrayList Sort? A/B");
                    userChoice = Console.ReadLine();
                } while (userChoice.ToLower().Equals("b"));
            }
        }
        public static void PrintValues(int[] myArr)
        {
            foreach (int i in myArr)
            {
                Console.WriteLine("\t{0}", i);
            }
        }
        //ArrayList Enumerator to display values
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
            {
                Console.Write("\t {0}", obj);
                Console.WriteLine();
            }

        }
    }
    
}
