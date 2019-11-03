
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
            Dictionary<string, Stack<int>> Towers = new Dictionary<string, Stack<int>>()
            {
                {"A", new Stack<int>() },
                {"B", new Stack<int>() },
                {"C", new Stack<int>() },
            };
            for (int i = 1; i <= 4; i++)
            {
                Towers["A"].Push(i);
            }
            GameBoard(Towers);
            Console.WriteLine("\n" + "Which tower do you want to move the top piece from?");
            string FromStack = Console.ReadLine().ToUpper();
            Console.WriteLine("\n" + "Which tower do you want to move the piece to?");
            string ToStack = Console.ReadLine().ToUpper();
            LegalMove(Towers, FromStack, ToStack);
        }
        static void GameBoard(Dictionary<string, Stack<int>> Towers)
        {
            foreach (var item in Towers)
            {


                Console.Write(item.Key + "| ");
                foreach (int X in item.Value)
                {
                    Console.Write(" " + X + " ");
                }
                Console.Write("\n");
            }

        }
        public static void LegalMove(Dictionary<string, Stack<int>> Towers, string FromStack, string ToStack)
        {
            
            
            if (Towers[FromStack].Count == 0)
            {
                Console.WriteLine("Illegal move. Please enter a valid tower: ");
            }
            else if (Towers[FromStack].Peek() > Towers[ToStack].Peek())
            {
                Console.WriteLine("Illegal move. Please enter a valid tower: ");
            }
        }


    }
}