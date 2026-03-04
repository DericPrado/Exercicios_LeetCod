using System;

namespace Special_Positions_in_a_Binary_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Segue o link do desafio: https://leetcode.com/problems/special-positions-in-a-binary-matrix/description/?envType=daily-question&envId=2026-03-04
             */

            int[][] mat = [[1, 0, 0], [0, 0, 1], [1, 0, 0]];
            Console.WriteLine(NumSpecial(mat));
        }

        public static int NumSpecial(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            int[] rowCount = new int[m];
            int[] colCount = new int[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        rowCount[i]++;
                        colCount[j]++;
                    }
                }
            }

            int res = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 1 && rowCount[i] == 1 && colCount[j] == 1)
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}
