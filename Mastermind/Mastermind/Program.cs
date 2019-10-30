using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        //computer color 1
        public static int Color1;
        //computer color 2
        public static int Color2;
        //user color 1
        public static int Guess1;
        //user color 2
        public static int Guess2;
        public static bool Win = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mastermind!");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Please guess 2 colors from Red Yellow and Blue.");
            Console.WriteLine("Hint Legend: [0-0]: both colors incorrect");
            Console.WriteLine("             [1-0]: one color correct but not at correct position");
            Console.WriteLine("             [0-1]: one color correct and at correct position");
            Console.WriteLine("             [2-0]: both colors correct but at wrong positions");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Random generator = new Random();
            // creates a number 0,1 or 2
            int randomColor1 = generator.Next(0, 3);
            switch (randomColor1)
            {
                case 0:

                    Color1 = 0; //red
                    break;
                case 1:

                    Color1 = 1; //yellow
                    break;
                case 2:

                    Color1 = 2; //blue
                    break;
            }
            int randomColor2 = generator.Next(0, 3);
            switch (randomColor2)
            {
                case 0:

                    Color2 = 0; //red
                    break;
                case 1:

                    Color2 = 1; //yellow
                    break;
                case 2:

                    Color2 = 2; //blue
                    break;
            }
            do
            {
                Console.WriteLine("Enter: [0 for Red] [1 for Yellow] [2 for Blue] ");
                Console.WriteLine("Enter your 1st color: ");
                Guess1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your 2nd color: ");
                Guess2 = int.Parse(Console.ReadLine());
                //Console.WriteLine("Comp1 color is " + Color1);  //view computer random colors for testing
                //Console.WriteLine("Comp2 color is " + Color2);  //view computer random colors for testing
                CompareColors(Color1, Color2, Guess1, Guess2);
            } while (Win == false);
        }
        //method that compares user guess to computer random colors for win condition
        public static void CompareColors(int Color1, int Color2, int Guess1, int Guess2)
        {
            List<int> CompColors = new List<int> { Color1, Color2 };
            List<int> UserColors = new List<int> { Guess1, Guess2 };
            if ((UserColors[0] == CompColors[0]) && (UserColors[1] == CompColors[1]))
            {
                Console.WriteLine("You win!");
                Win = true;
            }
            else if (((CompColors.Contains(Guess1)) && CompColors.Contains(Guess2)) && ((UserColors[0] != CompColors[0]) && (UserColors[1] != CompColors[1])))
            {
                Console.WriteLine("Your hint is 2-0");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            else if ((UserColors[0] == CompColors[0] || (UserColors[1] == CompColors[1])))
            {
                Console.WriteLine("Your hint is 0-1");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            else if (((CompColors.Contains(Guess1)) || (CompColors.Contains(Guess2))) && ((UserColors[0] != CompColors[0]) && (UserColors[1] != CompColors[1])))
            {
                Console.WriteLine("Your hint is 1-0");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            else if ((!CompColors.Contains(Guess1)) && (!CompColors.Contains(Guess2)))
            {
                Console.WriteLine("Your hint is 0-0");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
    }
}
