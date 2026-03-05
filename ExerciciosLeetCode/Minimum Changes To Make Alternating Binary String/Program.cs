namespace Minimum_Changes_To_Make_Alternating_Binary_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Segue o link do desafio: https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string/description/?envType=daily-question&envId=2026-03-05
             */
        }

        public int MinOperations(string s)
        {
            int count = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if((i % 2 == 0 && s[i] != '0') || (i % 2 != 0 && s[i] != '1'))
                {
                    count++;
                }
            }

            return Math.Min(count, (s.Length - count));
        }
    }
}
