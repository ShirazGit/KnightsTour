using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    partial class Board : Boxes
    {
        //creating movement 

        //two right, one up
        public static void move0(Boxes[,] board)
        {
            board[i, j].hasKnight = false;
            i = i + 2;
            j = j + 1;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            { //  all these must be true to ensure it is within board bounds
                if (board[i, j].isTouched() == true)
                {
                    i = i - 2;
                    j = j - 1;
                    moveAttempts++;
                    return;
                }
                board[i, j].hasKnight = true;
                board[i, j].setTouched(true);
                count++;
                board[i, j].counter = count;
                moveAttempts = 0;
            }

            else
            {
                i = i - 2;
                j = j - 1;
                board[i, j].hasKnight = true;
                moveAttempts++;
                return;

            }
        }
        //one right, two up
        public static void move1(Boxes[,] board)
        {
            board[i, j].hasKnight = false;
            //		board[i,j].setTouched(true);
            i = i + 1;
            j = j + 2;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            {
                if (board[i, j].isTouched() == true)
                {
                    i -= 1;
                    j -= 2;
                    moveAttempts++;
                    return;
                }
                board[i, j].hasKnight = true;
                board[i, j].setTouched(true);
                count++;
                board[i, j].counter = count;
                moveAttempts = 0;
            }

            else
            {
                i -= 1;
                j -= 2;
                board[i, j].hasKnight = true;
                moveAttempts++;
                return;

            }
        }
        //one left, two up
        public static void move2(Boxes[,] board)
        {
            board[i, j].hasKnight = false;
            //		board[i,j].setTouched(true);
            i = i - 1;
            j = j + 2;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            {
                if (board[i, j].isTouched() == true)
                {
                    i += 1;
                    j -= 2;
                    moveAttempts++;
                    return;
                }
                board[i, j].hasKnight = true;
                board[i, j].setTouched(true);
                count++;
                board[i, j].counter = count;
                moveAttempts = 0;
            }
            else
            {
                i += 1;
                j -= 2;
                board[i, j].hasKnight = true;
                moveAttempts++;
                return;

            }
        }
        //two left, one up
        public static void move3(Boxes[,] board)
        {
            board[i, j].hasKnight = false;
            //		board[i,j].setTouched(true);
            i = i - 2;
            j = j + 1;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            {
                if (board[i, j].isTouched() == true)
                {
                    i += 2;
                    j -= 1;
                    moveAttempts++;
                    return;
                }
                board[i, j].hasKnight = true;
                board[i, j].setTouched(true);
                count++;
                board[i, j].counter = count;
                moveAttempts = 0;
            }
            else
            {
                i += 2;
                j -= 1;
                board[i, j].hasKnight = true;
                moveAttempts++;
                return;

            }
        }
        //two left, one down
        public static void move4(Boxes[,] board)
        {
            board[i, j].hasKnight = false;
            //		board[i,j].setTouched(true);
            i = i - 2;
            j = j - 1;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            {
                if (board[i, j].isTouched() == true)
                {
                    i += 2;
                    j += 1;
                    moveAttempts++;
                    return;
                }
                board[i, j].hasKnight = true;
                board[i, j].setTouched(true);
                count++;
                board[i, j].counter = count;
                moveAttempts = 0;
            }

            else
            {
                i += 2;
                j += 1;
                board[i, j].hasKnight = true;
                moveAttempts++;
                return;

            }
        }
        //one left, two down
        public static void move5(Boxes[,] board)
        {
            board[i, j].hasKnight = false;
            //		board[i,j].setTouched(true);
            i = i - 1;
            j = j - 2;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            {
                if (board[i, j].isTouched() == true)
                {
                    i += 1;
                    j += 2;
                    moveAttempts++;
                    return;
                }
                board[i, j].hasKnight = true;
                board[i, j].setTouched(true);
                count++;
                board[i, j].counter = count;
                moveAttempts = 0;
            }
            else
            {
                i += 1;
                j += 2;
                board[i, j].hasKnight = true;
                moveAttempts++;
                return;
            }
        }
        //one right, two down
        public static void move6(Boxes[,] board)
        {
            board[i, j].hasKnight = false;
            //		board[i,j].setTouched(true);
            i = i + 1;
            j = j - 2;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            {
                if (board[i, j].isTouched() == true)
                {
                    i -= 1;
                    j += 2;
                    moveAttempts++;
                    return;
                }
                board[i, j].hasKnight = true;
                board[i, j].setTouched(true);
                count++;
                board[i, j].counter = count;
                moveAttempts = 0;
            }

            else
            {
                i -= 1;
                j += 2;
                board[i, j].hasKnight = true;
                moveAttempts++;
                return;

            }
        }
        //two right, one down
        public static void move7(Boxes[,] board)
        {
            board[i, j].hasKnight = false;
            //		board[i,j].setTouched(true);
            i += 2;
            j -= 1;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            {
                if (board[i, j].isTouched() == true)
                {
                    i -= 2;
                    j += 1;
                    moveAttempts++;
                    return;
                }
                board[i, j].hasKnight = true;
                board[i, j].setTouched(true);
                count++;
                board[i, j].counter = count;
                moveAttempts = 0;
            }
            else
            {
                i -= 2;
                j += 1;
                board[i, j].hasKnight = true;
                moveAttempts++;
                return;

            }
        }

        //check to see if box was touched previously
        //to be used after each move
        //if this is true, then board moves must end
        public static bool ifTouched(Boxes[,] board)
        {
            bool wasTouched;
            wasTouched = board[i, j].isTouched();
            return wasTouched;
        }


        //switch case to choose move method
        public static void autoMove(Boxes[,] board)
        {

            if (smart == true)
            { //will move according to heuristics
                Board.smartMove(board);
            }

            switch (Board.movement)
            {
                case 0:
                    move0(board);
                    break;
                case 1:
                    move1(board);
                    break;
                case 2:
                    move2(board);
                    break;
                case 3:
                    move3(board);
                    break;
                case 4:
                    move4(board);
                    break;
                case 5:
                    move5(board);
                    break;
                case 6:
                    move6(board);
                    break;
                case 7:
                    move7(board);
                    break;
            }
            
        }

        public static int checkPriority0(Boxes[,] board)
        { //checks the priority if the Knight moved using move0()
            int c, r;
            i = i + 2;
            j = j + 1;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            { //move0 check
                if (board[i, j].isTouched() == false)
                {
                    c = i;
                    r = j;
                    i = i - 2;
                    j = j - 1;
                    return board[c, r].getPriority();
                }
            }
            i = i - 2;
            j = j - 1;
            return 0;

        }
        public static int checkPriority1(Boxes[,] board)
        { //checks the priority if the Knight moved using move1()
            int c, r;
            i = i + 1;
            j = j + 2;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            { //move1 check
                if (board[i, j].isTouched() == false)
                {
                    c = i;
                    r = j;
                    i = i - 1;
                    j = j - 2;
                    return board[c, r].getPriority();
                }
            }
            i = i - 1;
            j = j - 2;
            return 0;

        }
        public static int checkPriority2(Boxes[,] board)
        {
            int c, r;
            i = i - 1;
            j = j + 2;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            { //move2 check
                if (board[i, j].isTouched() == false)
                {
                    c = i;
                    r = j;
                    i = i + 1;
                    j = j - 2;
                    return board[c, r].getPriority();
                }
            }
            i = i + 1;
            j = j - 2;
            return 0;
        }
        public static int checkPriority3(Boxes[,] board)
        {
            int c, r;
            i = i - 2;
            j = j + 1;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            { //move3 check
                if (board[i, j].isTouched() == false)
                {
                    c = i;
                    r = j;
                    i = i + 2;
                    j = j - 1;
                    return board[c, r].getPriority();
                }
            }
            i = i + 2;
            j = j - 1;
            return 0;

        }
        public static int checkPriority4(Boxes[,] board)
        {
            int c, r;
            i = i - 2;
            j = j - 1;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            {//move4 check
                if (board[i, j].isTouched() == false)
                {
                    c = i;
                    r = j;
                    i = i + 2;
                    j = j + 1;
                    return board[c, r].getPriority();
                }
            }
            i = i + 2;
            j = j + 1;
            return 0;

        }
        public static int checkPriority5(Boxes[,] board)
        {
            int c, r;
            i = i - 1;
            j = j - 2;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            { //move5 check
                if (board[i, j].isTouched() == false)
                {
                    c = i;
                    r = j;
                    i = i + 1;
                    j = j + 2;
                    return board[c, r].getPriority();
                }
            }
            i = i + 1;
            j = j + 2;
            return 0;

        }
        public static int checkPriority6(Boxes[,] board)
        {
            int c, r;
            i = i + 1;
            j = j - 2;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            { //move6 check
                if (board[i, j].isTouched() == false)
                {
                    c = i;
                    r = j;
                    i = i - 1;
                    j = j + 2;
                    return board[c, r].getPriority();
                }
            }
            i = i - 1;
            j = j + 2;
            return 0;

        }
        public static int checkPriority7(Boxes[,] board)
        {
            int c, r;
            i = i + 2;
            j = j - 1;
            if (checkMaxCol() == true && checkMinCol() == true && checkMaxRow() == true && checkMinRow() == true)
            { //move7 check
                if (board[i, j].isTouched() == false)
                {
                    c = i;
                    r = j;
                    i = i - 2;
                    j = j + 1;
                    return board[c, r].getPriority();
                }
            }
            i = i - 2;
            j = j + 1;
            return 0;
        }

        public static void smartMove(Boxes[,] board)
        { //chooses the first move method with the lowest priority value

            List<int> moving = new List<int>();
            Random rand = new Random();

            if (checkPriority0(board) == 2)
            {
                Board.movement = 0;
                return;
            }

            else if (checkPriority1(board) == 2)
            {
                Board.movement = 1;
                return;
            }

            else if (checkPriority2(board) == 2)
            {
                Board.movement = 2;
                return;
            }

            else if (checkPriority3(board) == 2)
            {
                Board.movement = 3;
                return;
            }

            else if (checkPriority4(board) == 2)
            {
                Board.movement = 4;
                return;
            }

            else if (checkPriority5(board) == 2)
            {
                Board.movement = 5;
                return;
            }

            else if (checkPriority6(board) == 2)
            {
                Board.movement = 6;
                return;
            }

            else if (checkPriority7(board) == 2)
            {
                Board.movement = 7;
                return;
            }

            if (checkPriority0(board) == 3)
            {
                moving.Add(0);
            }

            if (checkPriority1(board) == 3)
            {
                moving.Add(1);
            }

            if (checkPriority2(board) == 3)
            {
                moving.Add(2);
            }

            if (checkPriority3(board) == 3)
            {
                moving.Add(3);

            }

            if (checkPriority4(board) == 3)
            {
                moving.Add(4);

            }

            if (checkPriority5(board) == 3)
            {
                moving.Add(5);

            }

            if (checkPriority6(board) == 3)
            {
                moving.Add(6);

            }

            if (checkPriority7(board) == 3)
            {
                moving.Add(7);

            }

            if (moving.Count > 0)
            {
                Board.movement = moving[(int)(rand.Next(moving.Count - 1))];
                moving.Clear();
                return;
            }

            if (checkPriority0(board) == 4)
            {
                moving.Add(0);

            }

            if (checkPriority1(board) == 4)
            {
                moving.Add(1);

            }

            if (checkPriority2(board) == 4)
            {
                moving.Add(2);

            }

            if (checkPriority3(board) == 4)
            {
                moving.Add(3);

            }

            if (checkPriority4(board) == 4)
            {
                moving.Add(4);
            }

            if (checkPriority5(board) == 4)
            {
                moving.Add(5);
            }

            if (checkPriority6(board) == 4)
            {
                moving.Add(6);
            }

            if (checkPriority7(board) == 4)
            {
                moving.Add(7);
            }

            if (moving.Count > 0)
            {
                Board.movement = moving[(int)(rand.Next(moving.Count - 1))];
                moving.Clear();
                return;
            }

            if (checkPriority0(board) == 6)
            {
                moving.Add(0);
            }

            if (checkPriority1(board) == 6)
            {
                moving.Add(1);
            }

            if (checkPriority2(board) == 6)
            {
                moving.Add(2);
            }

            if (checkPriority3(board) == 6)
            {
                moving.Add(3);
            }

            if (checkPriority4(board) == 6)
            {
                moving.Add(4);
            }

            if (checkPriority5(board) == 6)
            {
                moving.Add(5);
            }

            if (checkPriority6(board) == 6)
            {
                moving.Add(6);
            }

            if (checkPriority7(board) == 6)
            {
                moving.Add(7);
            }

            if (moving.Count > 0)
            {
                Board.movement = moving[(int)(rand.Next(moving.Count - 1))];
                moving.Clear();
                return;
            }

            if (checkPriority0(board) == 8)
            {
                moving.Add(0);
            }

            if (checkPriority1(board) == 8)
            {
                moving.Add(1);
            }

            if (checkPriority2(board) == 8)
            {
                moving.Add(2);
            }

            if (checkPriority3(board) == 8)
            {
                moving.Add(3);
            }

            if (checkPriority4(board) == 8)
            {
                moving.Add(4);
            }

            if (checkPriority5(board) == 8)
            {
                moving.Add(5);
            }

            if (checkPriority6(board) == 8)
            {
                moving.Add(6);
            }

            if (checkPriority7(board) == 8)
            {
                moving.Add(7);
            }

            if (moving.Count > 0)
            {
                Board.movement = moving[(int)(rand.Next(moving.Count - 1))];
                moving.Clear();
                return;
            }

            else
                return;
        }
    }
}
