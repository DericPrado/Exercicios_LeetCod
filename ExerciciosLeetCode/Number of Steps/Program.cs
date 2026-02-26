using System.Numerics;

namespace Number_of_Steps_to_Reduce_a_Number_in_Binary_Representation_to_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Segue o link do desafio: https://leetcode.com/problems/number-of-steps-to-reduce-a-number-in-binary-representation-to-one/description/?envType=daily-question&envId=2026-02-26
             */

            string s = "1111110011101010110011100100101110010100101110111010111110110010";
            Console.WriteLine($"O resultado foi: {NumSteps(s)}");
        }

        public static int NumSteps(string s)
        {
            BigInteger n = 0;
            int steps = 0;

            foreach (char bit in s)
            {
                n = n * 2 + (bit - '0');
            }

            while (n > 1)
            {
                if (n % 2 != 0)
                {
                    n++;
                    steps++;
                }
                else
                {
                    n = n / 2;
                    steps++;
                }
            }

            return steps;
        }
    }
}
