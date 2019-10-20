using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets go! Rock, Paper, Scissors?");
            string hand1 = Console.ReadLine().ToLower();

            Random generator = new Random();
            // creates a number 0,1 or 2
            int randomNumber = generator.Next(0, 3);
            string hand2 = null;

            //assigns computers play of rock, paper or scissors randomly

            switch (randomNumber)
            {
                case 0:
                    Console.WriteLine("rock");
                    hand2 = "rock";
                    break;
                case 1:
                    Console.WriteLine("paper");
                    hand2 = "paper";
                    break;
                case 2:
                    Console.WriteLine("scissors");
                    hand2 = "scissors";
                    break;
            }

            
            CompareHands(hand1, hand2);

        }


            public static void CompareHands(String hand1, String hand2)
        {
            
            if ((hand1 == "rock") && (hand2 == "scissors"))
            {
                Console.WriteLine("You win!");
            }

            else if ((hand1 == "scissors") && (hand2 == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else if ((hand1 == "paper") && (hand2 == "rock"))
            {
                Console.WriteLine("You win!");
            }
            else if (hand1 == hand2)
            {
                Console.WriteLine("Game is a tie");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
            

        }





    }
}
