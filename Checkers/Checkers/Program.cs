using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    public struct Position
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
    public enum Color { White, Black }

    public class Checker
    {
        public String Symbol { get; private set; }
        public Color Team { get; private set; }
        public Position Position { get; set; }

        public Checker(Color team, int row, int col)
        {
            if(team == Color.White)
            {
                int symbol = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber); //'white' or open circle
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.White;
            }
            else
            {
                int symbol = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber); //'black' or closed circle
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.Black;
            }
            Position = new Position(row, col);
        }
    }
    public class Board
    {
        public List<Checker> checkers;
        public Board()
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    Checker cW = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(cW);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    Checker cB = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                    checkers.Add(cB);
                }
            }
        }
        public Checker GetChecker(Position pos)
        {
            foreach (Checker c in checkers)
            {
                if(c.Position.Row == pos.Row && c.Position.Col == pos.Col)
                {
                    return c;
                }
            }
            return null;
        }
        public void RemoveChecker(Checker checker)
        {
            if(checker != null)
            {
                checkers.Remove(checker);
            }
        }
        public void MoveChecker(Checker checker, Position dest)
        {
            Checker c = new Checker(checker.Team, dest.Row, dest.Col);
            checkers.Add(c);
            checkers.Remove(checker);
        }
    }
    public class Game
    {
        private Board board;
        public Game()
        {
            this.board = new Board();
        }
        private bool CheckForWin()
        {
            return board.checkers.All(x => x.Team == Color.White) || board.checkers.All(x => x.Team == Color.Black);
        }
        public void Start()
        {
            DrawBoard();
            while (!CheckForWin())
            {
                ProcessInput();
                DrawBoard();
            }
            Console.WriteLine("You won!");
        }
        public bool IsLegalMove(Position src, Position dest)
        {
            //make sure src and dest points are not outside game board
            if (src.Row < 0 || src.Row > 7 || src.Col < 0 || src.Col > 7
                || dest.Row < 0 || dest.Row > 7 || dest.Col < 0 || dest.Col > 7)
            {
                return false;
            }
            int RowDistance = Math.Abs(dest.Row - src.Row);
            int ColDistance = Math.Abs(dest.Col - src.Col);
            //check if move is horizontal or vertical
            if(RowDistance == 0 || ColDistance == 0)
            {
                return false;
            }
            if(RowDistance / ColDistance != 1)
            {
                return false;
            }
            if (RowDistance > 2)
            {
                return false;
            }
            //must be a checker at the src position
            Checker cs = board.GetChecker(src);
            Checker cd = board.GetChecker(dest);
            if (cs == null)
            {
                return false;
            }
            //can't be a checker at dest position
            if (cd != null)
            {
                return false;
            }
            if (RowDistance == 2)
            {
                if (IsCapture(src, dest))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //it is valid move 1 space diagnoally
                return true;
            }
        }
        public bool IsCapture(Position src, Position dest)
        {
            int RowDistance = Math.Abs(dest.Row - src.Row);
            int ColDistance = Math.Abs(dest.Col - src.Col);
            if(RowDistance == 2 && ColDistance == 2)
            {
                //must be checker in middle of src and dest
                int rowMid = (dest.Row + src.Row) / 2;
                int colMid = (dest.Col + src.Col) / 2;
                Position p = new Position(rowMid, colMid);
                Checker c = board.GetChecker(p);
                Checker player = board.GetChecker(src);
                //if mid point is empty, can't move 2 spaces
                if (c == null)
                {
                    return false;
                }
                else
                {
                    if (c.Team == player.Team)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }
        public Checker GetCaptureChecker(Position src, Position dest)
        {
            if(IsCapture(src, dest))
            {
                int rowMid = (dest.Row + src.Row) / 2;
                int colMid = (dest.Col + src.Col) / 2;
                Position p = new Position(rowMid, colMid);
                Checker c = board.GetChecker(p);
                return c;
            }
            else
            {
                return null;
            }
        }
        public void ProcessInput()
        {
            Console.WriteLine("Select a checker to move & include comma after Row (Row, Column): ");
            string From = Console.ReadLine().Trim();
            Console.WriteLine("Select space to move to & include comma after Row (Row, Column): ");
            String To = Console.ReadLine().Trim();
            string[] Source = From.Split(',');
            string[] Destination = To.Split(',');
            Position Src = new Position(int.Parse(Source[0]), int.Parse(Source[1]));
            Position Dest = new Position(int.Parse(Destination[0]), int.Parse(Destination[1]));
            Checker c = board.GetChecker(Src);
            if (c == null)
            {
                Console.WriteLine("Invalid move");
            }
            else
            {
                //check if move is legal and if it's a capture move
                if (IsLegalMove(Src, Dest))
                {
                    //if legal move was a capture move, move source checker and remove captured checker from board
                    if (GetCaptureChecker(Src, Dest) != null)
                    {
                        board.RemoveChecker(GetCaptureChecker(Src, Dest));
                        board.MoveChecker(c, Dest);
                    }
                    else
                    {
                        //move checker and remove original location
                        board.MoveChecker(c, Dest);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again :");
                }
            }
        }
        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.checkers)
            {
                grid[c.Position.Row][c.Position.Col] = c.Symbol;
            }
            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int r = 0; r < 8; r++)
            {
                Console.Write(r);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(" {0}", grid[r][c]);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game game = new Game();
            game.Start();
            game.DrawBoard();
        }
    }
}