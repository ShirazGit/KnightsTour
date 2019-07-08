using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WindowsFormsApp2
{
    partial class Board : Boxes
    {
        public static int i, j, movement, moveAttempts = 0;
        public static bool smart = true;

        public static Boxes[,] createBoard()
        {
            Boxes[,] board = new Boxes[8, 8];
            //instantiating box objects into the array to create a chess board
            for (int i = 0; i <= board.GetLength(0)-1; i++)
            {
                for (int j = 0; j <= board.GetLength(1)-1; j++)
                {
                    board[i, j] = new Boxes();
                    board[i, j].setTouched(false);
                    board[i, j].setKnight(false);
                }
            }
            //setting priority values for each box
            board[0, 0].setPriority(2);
            board[0, 7].setPriority(2);
            board[7, 0].setPriority(2);
            board[7, 7].setPriority(2);
            board[0, 1].setPriority(3);
            board[0, 6].setPriority(3);
            board[1, 0].setPriority(3);
            board[1, 7].setPriority(3);
            board[6, 0].setPriority(3);
            board[6, 7].setPriority(3);
            board[7, 1].setPriority(3);
            board[7, 6].setPriority(3);
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    board[i, j].setPriority(4);
                }
            }
            for (int i = 2; i <= 5; i++)
            {
                board[i, 0].setPriority(4);
                board[i, 7].setPriority(4);
            }
            board[1, 1].setPriority(4);
            board[1, 6].setPriority(4);
            board[6, 1].setPriority(4);
            board[6, 6].setPriority(4);

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    board[i, j].setPriority(6);
                }
            }
            for (int i = 2; i <= 5; i++)
            {
                board[i, 1].setPriority(6);
                board[i, 6].setPriority(6);
            }

            for (int i = 2; i <= 5; i++)
            {
                for (int j = 2; j <= 5; j++)
                    board[i, j].setPriority(8);
            }
            return board;
        }

        //this is to set the first piece on the board
        public static void setBoard(Boxes[,] board)
        {
            board[i, j].hasKnight = true;
            board[i, j].setTouched(true);
            Boxes.count = 1;
            board[i, j].counter = 1;
        }
        //reset everything
        public static void clearBoard(Boxes[,] board)
        {
            Board.moveAttempts = 0;
            for (int i = 0; i <= board.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= board.GetLength(1) - 1; j++)
                {
                    board[i, j].setTouched(false);
                    board[i, j].setKnight(false);
                    Boxes.count = 0;
                    board[i, j].counter = 0;
                }
            }

        }

        //print board to Console and String
        public static void printBoard(Boxes[,] board)
        {
            for (int j = 0; j < board.GetLength(0); j++)
            {
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    Console.Write(String.Format("{0,-4}", board[i, j].counter));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static string showBoard(Boxes[,] board, string s)
        {
            for (int j = 0; j < board.GetLength(0); j++)
            {
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    s += String.Format("{0,-4}",board[i, j].counter.ToString());
                }
                s+="\n";
            }
            return s;
        }


        //not implemented but to verify the board priorities are set correctly when troubleshooting
        public static void printPriorities(Boxes[,] board)
        {
            for (int j = 0; j < board.GetLength(0); j++)
            {
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    Console.Write(String.Format("{0,-4}", board[i, j].getPriority()));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        //checking if movement is within bounds of array
        //if true, it means it is within the column bounds
        public static bool checkMaxCol()
        {
            int moveCol = Board.i;
            int maxColumn = 7;
            if (moveCol <= maxColumn)
                return true;
            else
                return false;
        }

        public static bool checkMinCol()
        {
            int moveCol = Board.i;
            int minColumn = 0;
            if (moveCol >= minColumn)
                return true;
            else
                return false;
        }
        //if true, it means it is within the row bounds
        public static bool checkMaxRow()
        {
            int moveRow = Board.j;
            int maxRow = 7;
            if (moveRow <= maxRow)
                return true;
            else
                return false;
        }
        public static bool checkMinRow()
        {
            int moveRow = Board.j;
            int minRow = 0;
            if (moveRow >= minRow)
                return true;
            else
                return false;
        }
    }
}
