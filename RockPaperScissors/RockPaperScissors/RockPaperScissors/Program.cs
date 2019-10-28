﻿using System;

namespace RockPaperScissors
{
    class Program
    {
        //int PlayerScore = 0; (score tracking work in progress)
        //int CompScore = 0;   (score tracking work in progress)
        //main program/method
        static void Main(string[] args)
        {
            do
            {
                Game();
                Console.WriteLine("Play again? (yes/no)");
            } while (Console.ReadLine().ToLower() == "yes");
        }
        //game method that randomly assigns computer hand and calls CompareHands to determine winner
        public static void Game()
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
            //method that compares user hand to computer hand to determine winner
            public static void CompareHands(String hand1, String hand2)
        {
            //int PlayerScore = 0; (score tracking work in progress)
            //int CompScore = 0;   (score tracking work in progress)
            if ((hand1 == "rock") && (hand2 == "scissors"))
            {
                Console.WriteLine("You win!");
                //PlayerScore++; (score tracking work in progress)
            }
            else if ((hand1 == "scissors") && (hand2 == "paper"))
            {
                Console.WriteLine("You win!");
                //PlayerScore++; (score tracking work in progress)
            }
            else if ((hand1 == "paper") && (hand2 == "rock"))
            {
                Console.WriteLine("You win!");
                //PlayerScore++; (score tracking work in progress)
            }
            else if (hand1 == hand2)
            {
                Console.WriteLine("Game is a tie");
            }
            else
            {
                Console.WriteLine("Computer wins!");
                //CompScore++; (score tracking work in progress)
            }
        }
        //method to track score for further practice (work in progress)
        /*public static void Score(int PlayerScore, int CompScore)
        {
            

        }*/

    }
}



