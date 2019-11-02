
using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Towers of Hanoi!" + "\n");
            Console.WriteLine("Rules of the game:" + "\n");
            Console.WriteLine("1. Blocks can only be moved to be on top of larger blocks.");
            Console.WriteLine("2. Only the top block from any stack can be moved.");
            Console.WriteLine("3. You win the game by moving entire stack from tower A to Tower C." + "\n");
            Dictionary<string, Stack<int>> towers = new Dictionary<string, Stack<int>>()
            {
                {"A", new Stack<int>() },
                {"B", new Stack<int>() },
                {"C", new Stack<int>() },
            };
            for (int i = 1; i <= 4; i++)
            {
                towers["A"].Push(i);
                //towers["B"].Push(0);
                //towers["C"].Push(0);
            }
            GameBoard(towers);
            Console.WriteLine("\n" + "Which tower do you want to move the top piece from?");
            string Piece = Console.ReadLine().ToUpper();
            Console.WriteLine("\n" + "Which tower do you want to move the piece to?");
            string Place = Console.ReadLine().ToUpper(); 
        }
        static void GameBoard(Dictionary<string, Stack<int>> towers)
        {
            foreach (var item in towers)
            {


                Console.Write(item.Key + "| ");
                foreach (int X in item.Value)
                {
                    if (X == 0)
                        Console.Write(" - ");
                    else
                        Console.Write(" " + X + " ");
                }
                Console.Write("\n");


            }

        }
        //static void Test(Dictionary<string, Stack<int>> towers, string Piece, string Place)
        //{
        //    foreach (var item in towers)
        //    {
        //        foreach (char Y in item.Key)
        //        {
        //            if (Y = Piece)
        //            {

        //            }
        //        }
        //    }
           
        //}
       


    }
}