using System;

namespace TicTacToe
{
    class Program
    {
        public static bool PlayerXTurn = true;
        public static bool PlayerOTurn = false;
        public static int Row;
        public static int Column;
        public static string winner;
        public static string[] row1 = { " ", " ", " " };
        public static string[] row2 = { " ", " ", " " };
        public static string[] row3 = { " ", " ", " " };
        public static string[][] board = new string[3][];
        //main program/method
        public static void Main()
        {
            board[0] = row1;
            board[1] = row2;
            board[2] = row3;
            do
            {
                Console.WriteLine("    TIC TAC TOE" + "\r\n");
                PrintBoard();
                GetInput();
            } while (!HasWon() && !IsTie());
            if (HasWon())
            {
                Console.WriteLine("Player " + winner + " wins!");
            }
            if (IsTie())
            {
                Console.WriteLine("Game is a tie! ");
            }
            Console.WriteLine("Game Over");
        }
        //method prints out current players turn, ask user for row & column inputs, and updates the board
        public static void GetInput()
        {
            if (PlayerXTurn)
            {
                Console.WriteLine("Player X enter a row: ");
                Row = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Player X enter a column: ");
                Column = int.Parse(Console.ReadLine()) - 1;
                if (board[Row][Column] == " ")
                {
                    board[Row][Column] = "X";
                    PlayerXTurn = false;
                    PlayerOTurn = true;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("That space is already filled. ");
                        Console.WriteLine("Player X enter a row: ");
                        Row = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Player X enter a column: ");
                        Column = int.Parse(Console.ReadLine()) - 1;
                    } while (board[Row][Column] != " ");
                    board[Row][Column] = "X";
                    PlayerXTurn = false;
                    PlayerOTurn = true;
                }
            }
            else if (PlayerOTurn)
            {
                Console.WriteLine("Player O enter a row: ");
                Row = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Player O enter a column: ");
                Column = int.Parse(Console.ReadLine()) - 1;
                if (board[Row][Column] == " ")
                {
                    board[Row][Column] = "O";
                    PlayerOTurn = false;
                    PlayerXTurn = true;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("That space is already filled. ");
                        Console.WriteLine("Player O enter a row: ");
                        Row = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Player O enter a column: ");
                        Column = int.Parse(Console.ReadLine()) - 1;
                    } while (board[Row][Column] != " ");
                    board[Row][Column] = "O";
                    PlayerOTurn = false;
                    PlayerXTurn = true;
                }
            }  
        }
        //method to print board to console
        public static void PrintBoard()
        {
            Console.WriteLine("  1      2     3  ");
            Console.WriteLine("      |     |      ");
            Console.WriteLine("1 {0}   |  {1}  |  {2}", board[0][0], board[0][1], board[0][2]);
            Console.WriteLine(" _____|_____|_____ ");
            Console.WriteLine("      |     |      ");
            Console.WriteLine("2  {0}  |  {1}  |  {2}", board[1][0], board[1][1], board[1][2]);
            Console.WriteLine(" _____|_____|_____ ");
            Console.WriteLine("      |     |      ");
            Console.WriteLine("3 {0}   |  {1}  |  {2}", board[2][0], board[2][1], board[2][2]);
            Console.WriteLine("      |     |      ");
        }
        //method that checks for horizontal win
        public static bool IsHorizontalWin()
        {
            //check 1st row for win condition
            if ((board[0][0] == board[0][1] && board[0][1] == board[0][2]) && (board[0][1] != " "))
            {
                winner = board[0][0];
                return true;
            }
            //check 2nd row for win condition
            else if ((board[1][0] == board[1][1] && board[1][1] == board[1][2]) && (board[1][1] != " "))
            {
                winner = board[1][0];
                return true;
            }
            //check 3rd row for win condition
            else if ((board[2][0] == board[2][1] && board[2][1] == board[2][2]) && (board[2][1] != " "))
            {
                winner = board[2][0];
                return true;
            }
            else
            {
                return false;
            }
        }
        //method that checks for vertical win
        public static bool IsVerticalWin()
        {
            //check 1st column for win condition
            if ((board[0][0] == board[1][0] && board[1][0] == board[2][0]) && (board[1][0] != " "))
            {
                winner = board[0][0];
                return true;
            }
            //check 2nd column for win condition
            else if ((board[0][1] == board[1][1] && board[1][1] == board[2][1]) && (board[1][1] != " "))
            {
                winner = board[0][1];
                return true;
            }
            //check 3rd column for win condition
            else if ((board[0][2] == board[1][2] && board[1][2] == board[2][2]) && (board[1][2] != " "))
            {
                winner = board[0][2];
                return true;
            }
            else
            {
                return false;
            }
        }
        //method that checks for diagonal win
        public static bool IsDiagonalWin()
        {
            //check first diagonal for win condition
            if ((board[0][0] == board[1][1] && board[1][1] == board[2][2]) && (board[1][1] != " "))
            {
                winner = board[1][1];
                return true;
            }
            //check 2nd diagonal for win condition
            else if ((board[2][0] == board[1][1] && board[1][1] == board[0][2]) && (board[1][1] != " "))
            {
                winner = board[1][1];
                return true;
            }
            else
            {
                return false;
            }
        }
        //method that checks all win conditions
        public static bool HasWon()
        {
            if ((IsHorizontalWin()) || (IsVerticalWin()) || (IsDiagonalWin()))                            
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //method that checks for tie
        public static bool IsTie()
        {
            if ((!HasWon()) && (board[0][0] != " ") && (board[0][1] != " ") && (board[0][2] != " ") &&
                (board[1][0] != " ") && (board[1][1] != " ") && (board[1][2] != " ") &&
                (board[2][0] != " ") && (board[2][1] != " ") && (board[2][2] != " "))
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
