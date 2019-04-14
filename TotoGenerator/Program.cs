using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Compression;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] combination = new int[6];
            Random number = new Random();


            Console.WriteLine("This is simple generator for combinations for Toto 6/49.");
            Console.WriteLine();

            Console.WriteLine("Do you want new combination [Y/N]?");

            string command = Console.ReadLine();


            for (int i = 0; i < int.MaxValue; i++)
            {
                if (command == "Y")
                {
                    CombinationMethod(combination, number);
                    Console.WriteLine();
                    command = Console.ReadLine();
                }
                else if (command == "N")
                {
                    Console.WriteLine("Goodbay and good luck!");
                    break;
                }
            }
        }
        private static void CombinationMethod(int[] combination, Random number)
        {

            for (int i = 0; i < 6; i++)
            {
                combination[i] = number.Next(1, 50);
            }
            Array.Sort(combination);

            // добавям Лист, в който да съхранявам всички комбинации, за да не може генератора да даде две еднакви комбинации в определен момент

            //

            bool isUnique = combination.Distinct().Count() == combination.Count();

            if (isUnique)
            {
                List<int[]> generatedCombination = new List<int[]>();
                //Вкарвам генерираната комбинация в новосъздадения лист
                generatedCombination.Add(combination);
                //
                foreach (var thing in generatedCombination)
                {
                    Console.WriteLine(thing);
                }

                Console.Write("Your combination is: ");

                foreach (var numbers in combination)
                {

                    Console.Write(numbers + " ");


                }
            }
            else
            {
                CombinationMethod(combination, number);
            }


        }


    }


}
