using System;

namespace SudokuSolver
{
    class Program
    {

        static void Main(string[] args)
        {
            int[][] board = 
            {
                new int[]{7,8,0,4,0,0,1,2,0},
                new int[]{6,0,0,0,7,5,0,0,9},
                new int[]{0,0,0,6,0,1,0,7,8},
                new int[]{0,0,7,0,4,0,2,6,0},
                new int[]{0,0,1,0,5,0,9,3,0},
                new int[]{9,0,4,0,6,0,0,0,5},
                new int[]{0,7,0,3,0,0,0,1,2},
                new int[]{1,2,0,0,0,7,4,0,0},
                new int[]{0,4,9,2,0,6,0,0,7}
            };

            //Console.WriteLine(board.Length);
            //Console.WriteLine(board[1].Length);

            for(int i =0; i< board.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("- - - - - - - - -");

                }
                for (int j = 0; j < board[i].Length; j++)
                {

                    if (j % 3 == 0 && j != 0)
                    {
                        Console.Write("|\t");

                    }

                    if (j == 8)
                    {
                        Console.WriteLine(board[i][j]);
                        
                    }
                    else
                    {
                        Console.Write(board[i][j] + " ");
                    }

                }

            }
            findEmpty(board);
        }
        private static int[][] findEmpty(int[][] bo)
        {
            for (int k = 0; k < bo.Length; k++)
            {
                for (int m = 0; m < bo[0].Length; m++)
                {
                    if (bo[k][m] == 0)
                    {
                        return (k,m);
                    }
                }
            }
           
        }

    } 
}



        



