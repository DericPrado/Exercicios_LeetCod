namespace Binary_Number_with_Alternating_Bits
{
    /*
     Segue o link deste desafio: https://leetcode.com/problems/binary-number-with-alternating-bits/?envType=daily-question&envId=2026-02-18
     
     
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Insira o numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(HasAlternatingBits(n));

        }

        public static bool HasAlternatingBits(int n)
        {
            string bin = IntegerToBinary(n);

            char[] bins = bin.ToCharArray();

            char c = 'A';
            char d = 'B';

            for (int i = 0; i < bins.Length; i++)
            {
                if(i == 0)
                {
                    c = bins[i];
                }
                else
                {
                    d = bins[i];
                }

                if(c == d)
                {
                    return false;
                }
            }

            return true;
        }

        public static string IntegerToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
    }
}


