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
            int soma = 0;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    soma = nums[i] + nums[left] + nums[right];

                    if(soma == 0)
                    {
                        res.Add([nums[i], nums[left], nums[right]]);
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }

                    else if(soma < 0)
                    {
                        left++;
                    }

                    else if(soma > 0)
                    {
                        right--;
                    }
                }
            }

            return res;
        }
    }
}
