using System;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Addition();
            Catdog();
            Oddeven();
            Inches();
            Echo();
            Killgrams();
            Date();
            Age();
            Guess();


        }


        public static void Hello()
        {
            Console.WriteLine("Hello, what is your name?" + "\n");
            string response = Console.ReadLine();
            Console.WriteLine("\n" + "Bye," + response + "!" + "\n");
            Console.ReadKey();
        }

        public static void Addition()
        {
            Console.WriteLine("Please enter a number:" + "\n");
            string response1 = Console.ReadLine();
            int num1 = int.Parse(response1);
            Console.WriteLine("\n" + "Please enter another number:" + "\n");
            string response2 = Console.ReadLine();
            int num2 = int.Parse(response2);
            int total = num1 + num2;
            Console.WriteLine("\n" + total + " is the sum of your numbers." + "\n");

        }

        public static void Catdog()
        {
            Console.WriteLine("Do you prefer cats or dogs?" + "\n");
            string answer = Console.ReadLine().ToLower();
            string str1 = ("cats");
            string str2 = answer;
            if (string.Equals(str1, str2))
            {
                Console.WriteLine("\n" + "Meows" + "\n");
            }
            else
            {
                Console.WriteLine("\n" + "Barks" + "\n");
            }

        }

        public static void Oddeven()
        {
            Console.WriteLine("Please enter a number:" + "\n");
            string numb1 = Console.ReadLine();
            int number1 = int.Parse(numb1);
            if (number1 % 2 == 0)
            {
                Console.WriteLine("\n" + "Number is even." + "\n");
            }
            else
            {
                Console.WriteLine("\n" + "Number is odd." + "\n");
            }

        }

        public static void Inches()
        {
            Console.WriteLine("Please enter a height in feet:" + "\n");
            string height = Console.ReadLine();
            int height1 = int.Parse(height);
            int inches = (height1 * 12);
            Console.WriteLine("\n" + "The height you entered is " + inches + " inches." + "\n");


        }

        public static void Echo()
        {
            Console.WriteLine("Please enter a word:" + "\n");
            string word = Console.ReadLine();
            string upper = word.ToUpper();
            string lower = word.ToLower();
            Console.WriteLine("\n" + upper);
            Console.WriteLine(lower);
            Console.WriteLine(lower);
        }

        public static void Killgrams()
        {
            Console.WriteLine("\n" + "Please enter a weight in pounds:" + "\n");
            string weight = Console.ReadLine();
            int weight1 = int.Parse(weight);
            double kilo = (weight1 * 0.45359237);
            Console.WriteLine("\n" + "The weight you entered is " + kilo + " killograms." + "\n");

        }

        public static void Date()
        {
            string now = Convert.ToString(DateTime.Now.ToShortDateString());
            Console.WriteLine("Today's date: " + now);
        }

        public static void Age()
        {
            Console.WriteLine("\n" + "What is your birth year?" + "\n");
            string yearinput = Console.ReadLine();
            int year = int.Parse(yearinput);
            int age = (2019 - year);
            Console.WriteLine("\n" + "You are " + age + " years old." + "\n");
        }

        public static void Guess()
        {
            Console.WriteLine("\n" + "Please guess a word:" + "\n");
            string wordguess = Console.ReadLine();
            if (wordguess == "csharp")
            {
                Console.WriteLine("\n" + "CORRECT!!");
            }
            else
            {
                Console.WriteLine("\n" + "WRONG!!");
            }


        }









    }
}
