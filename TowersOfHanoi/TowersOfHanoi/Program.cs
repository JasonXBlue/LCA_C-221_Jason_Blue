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
            Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>()
            { 
                {"A", new Stack<int>() },
                {"B", new Stack<int>() },
                {"C", new Stack<int>() },
            };
            for (int i = 1; i <= 4; i++)
            {
                board["A"].Push(i);
                board["B"].Push(0);
                board["C"].Push(0);
            }
            GameBoard(board);
               
        }
        static void GameBoard(Dictionary<string, Stack<int>> board)
        {
            foreach (var item in board)
            {


                Console.Write(item.Key+"| ");
                foreach (int X in item.Value)
                {
                    if (X == 0)
                        Console.Write(" - ");
                    else    
                    Console.Write(" " + X +" ");
                }
                Console.Write("\n");


            }

        }


    }
}
