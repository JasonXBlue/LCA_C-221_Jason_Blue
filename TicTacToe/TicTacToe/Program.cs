using System;

namespace TicTacToe
{
    class Program
    {

        public static bool PlayerTurn = true;
        public static int Row;
        public static int Column;


        public static string[][] board =
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };


    
        public static void Main()
        {
            do
            {
                Console.WriteLine("---------------");
                PrintBoard();
                Console.WriteLine("---------------");
                GetInput();
                Console.WriteLine("---------------");
                PlayerTurn = !PlayerTurn;


            } while (!HasWon() && !IsTie());

            Console.WriteLine("Game Over");
            // leave this command at the end so program doesn't close automatically
            Console.ReadLine();
            
        }

        //method prints out current players turn, ask user for row & column inputs, and updates the board
        public static void GetInput()
        {
            Console.WriteLine("Player X enter a row: ");
            Row = int.Parse(Console.ReadLine());

            Console.WriteLine("Player X enter a column: ");
            Column = int.Parse(Console.ReadLine());

            board[Row][Column] = "X";

            Console.WriteLine("Player O enter a row: ");
            Row = int.Parse(Console.ReadLine());

            Console.WriteLine("Player O enter a column: ");
            Column = int.Parse(Console.ReadLine());

            board[Row][Column] = "O";
        }

        //method to print board to console
        public static void PrintBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1][1], board[1][2], board[1][3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[2][1], board[2][2], board[2][3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3][1], board[3][2], board[3][3]);
            Console.WriteLine("     |     |      ");



        }

        public static bool IsHorizontalWin()
        {
            //check 1st row for win condition
            if (board[1][1] == board[1][2] && board[1][2] == board[1][3])
            {
                return true;
            }
            //check 2nd row for win condition
            else if (board[2][1] == board[2][2] && board[1][2] == board[2][3])
            {
                return true;
            }
            //check 3rd row for win condition
            else if (board[3][1] == board[3][2] && board[3][2] == board[3][3])
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool IsVerticalWin()
        {
            //check 1st column for win condition
            if (board[1][1] == board[2][1] && board[2][1] == board[3][1])
            {
                return true;
            }
            //check 2nd column for win condition
            else if (board[1][2] == board[2][2] && board[2][2] == board[3][2])
            {
                return true;
            }
            //check 3rd column for win condition
            else if (board[1][3] == board[2][3] && board[2][3] == board[3][3])
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool IsDiagonalWin()
        {
            //check first diagonal for win condition
            if (board[1][1] == board[2][2] && board[2][2] == board[3][3])
            {
                return true;
            }
            //check 2nd diagonal for win condition
            else if (board[3][1] == board[2][2] && board[2][2] == board[1][3])
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool HasWon()
        {
            if ((IsHorizontalWin()) || (IsVerticalWin()) || (IsDiagonalWin()) == true)                            
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public static bool IsTie()
        {
            if ((!HasWon()) && (board[1][1] != " ") && (board[1][2] != " ") && (board[1][3] != " ") &&
                (board[2][1] != " ") && (board[2][2] != " ") && (board[2][3] != " ") &&
                (board[3][1] != " ") && (board[3][2] != " ") && (board[3][3] != " "))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
