namespace Count_Submatrices_with_Top_Left_Element_and_Sum_Less_Than_k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Segue o desafio: https://leetcode.com/problems/count-submatrices-with-top-left-element-and-sum-less-than-k/description/?envType=daily-question&envId=2026-03-18
             */
            int[][] grid = [[7, 7, 10, 9], [10, 5, 10, 3]];
            int k = 18;
            int res = CountSubmatrices(grid, k);

            Console.WriteLine(res);
        }
        public static int CountSubmatrices(int[][] grid, int k)
        {
            int countSubmatrix = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int sum = grid[i][j];

                    if (i > 0) sum += grid[i - 1][j];

                    if (j > 0) sum += grid[i][j - 1];

                    if (i > 0 && j > 0) sum -= grid[i - 1][j - 1];

                    grid[i][j] = sum;

                    if (sum <= k)
                    {
                        countSubmatrix++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return countSubmatrix;
        }

    }
}
