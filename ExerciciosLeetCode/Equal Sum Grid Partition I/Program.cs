namespace Equal_Sum_Grid_Partition_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Segue o desafio: https://leetcode.com/problems/equal-sum-grid-partition-i/description/?envType=daily-question&envId=2026-03-25
             */
        }

        public bool CanPartitionGrid(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            long totalSum = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    totalSum += grid[r][c];
                }
            }

            if (totalSum % 2 != 0)
            {
                return false;
            }

            long targetSum = totalSum / 2;

            long currentSum = 0;
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    currentSum += grid[r][c];
                }

                if (currentSum == targetSum)
                {
                    return true;
                }
            }

            currentSum = 0;
            for (int c = 0; c < cols - 1; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    currentSum += grid[r][c];
                }

                if (currentSum == targetSum)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
