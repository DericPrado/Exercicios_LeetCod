namespace Complement_of_Base_10_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                segue o link: https://leetcode.com/problems/complement-of-base-10-integer/description/?envType=daily-question&envId=2026-03-11 
            */
        }
        public int BitwiseComplement(int n)
        {
            string bin = Convert.ToString(n, 2);
            string replaces = "";
            for(int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '0')
                {
                    replaces += '1';
                }
                else
                {
                    replaces += '0';
                }
            }

            return Convert.ToInt32(replaces, 2);
        }
    }
}
