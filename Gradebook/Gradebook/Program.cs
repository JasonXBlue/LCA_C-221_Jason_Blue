using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    class Program
    {
        public static string Input;
        public static string Name;
        public static string Grades;
        public static Dictionary<string, string> StudentGrades = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a student's name or 'quit' to end: ");
                Input = Console.ReadLine().ToLower();
                if (Input != "quit")
                {
                    Name = Input;
                }       
                else if (Input == "quit")
                {
                    break;
                }
                Console.WriteLine("Enter the students grades separated by spaces (100 90 78 101 45 81) :");
                Grades = Console.ReadLine();
                StudentGrades.Add(Name, Grades);
            }
            Calculations();
        }
        static void Calculations()
        {
            foreach (var item in StudentGrades)
            {   
                string[] Nums = item.Value.Split(" ", item.Value.Length, StringSplitOptions.RemoveEmptyEntries);
                int[] myInts = Array.ConvertAll(Nums, int.Parse);
                int average = (int)myInts.Average();
                Console.WriteLine(" ");
                Console.WriteLine(item.Key);
                Console.WriteLine(" ");
                Console.WriteLine("Average is : " + average);
                Console.WriteLine(" ");
                Console.WriteLine("Highest grade is : " + myInts.Max());
                Console.WriteLine(" ");
                Console.WriteLine("Lowest grade is : " + myInts.Min());
            }

        }
    }
}
