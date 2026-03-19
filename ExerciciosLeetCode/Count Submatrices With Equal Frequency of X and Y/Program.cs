namespace Count_Submatrices_With_Equal_Frequency_of_X_and_Y
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Segue o link do desafio: https://leetcode.com/problems/count-submatrices-with-equal-frequency-of-x-and-y/description/?envType=daily-question&envId=2026-03-19
             */

            char[][] grid = [['X', 'Y', '.'], ['Y', '.', '.']];
            Console.WriteLine(NumberOfSubmatrices(grid));

        }
        public static int NumberOfSubmatrices(char[][] grid)
        {
            int countSubmatrix = 0;
            int countX = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 'X')
                    {
                        countX++;
                        sum++;
                    }
                    else if (grid[i][j] == 'Y')
                    {
                        sum--;
                    }

                    if(sum == 0 && countX > 0)
                    {
                        countSubmatrix++;
                    }
                }
            }

            return countSubmatrix;
        }
    }
}
