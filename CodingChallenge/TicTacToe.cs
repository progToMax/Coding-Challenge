using System;

namespace CodingChallenge
{
    public class TicTacToe
    {
        public string ProcessWinner(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (IsHorizontalWin(i, board))
                {
                    return board[i,0];
                }
                if (IsVerticalWin(i, board))
                {
                    return board[0,i];
                }
            }
            var middle = board.GetLength(0) / 2;
            if (IsDiagonalWin(middle , board))
            {
                return board[middle,middle];
            }

            return "-";
        }
        private bool IsDiagonalWin(int middle, string[,] board)
        {
            var centerval = board[middle, middle];
            var hasSolution1 = true;
            var hasSolution2 = true;
            for (int i=0; i < board.GetLength(0); i++)
            {
                if (board[i,i] != centerval)
                {
                    hasSolution1 = false;
                }
                if (board[i,board.GetLength(0) - 1 -i ] != centerval)
                {
                    hasSolution2 = false;
                }
                if (!hasSolution2 && !hasSolution1)
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsHorizontalWin(int row, string[,] board)
        {
            int cols = board.GetLength(0);
            string val = board[row, 0];
            for (int i = 1; i < cols; i++)
            {
                if (board[row, i] != val)
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsVerticalWin(int col, string[,] board)
        {
            int rows = board.GetLength(1);
            string val = board[0, col];
            for (int i = 1; i < rows; i++)
            {
                if (board[i, col] != val)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
