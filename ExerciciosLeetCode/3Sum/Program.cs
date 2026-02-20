namespace _3Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Segue o link do desafio: https://leetcode.com/problems/3sum/description/
            */
            int[] nums = [-1, 0, 1, 2, -1, -4];
            var res = ThreeSum(nums);

            Console.WriteLine(res);
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();
        }
    }
}
