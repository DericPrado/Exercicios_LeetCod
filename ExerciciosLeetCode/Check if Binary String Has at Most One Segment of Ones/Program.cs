namespace Check_if_Binary_String_Has_at_Most_One_Segment_of_Ones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Segue o link do desafio: https://leetcode.com/problems/check-if-binary-string-has-at-most-one-segment-of-ones/description/?envType=daily-question&envId=2026-03-06
             */
            string s = "1001";
            Console.Write(CheckOnesSegment(s));
        }

        public static bool CheckOnesSegment(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    if (i == 0)
                    {
                        count++;
                    }
                    else if (s[i - 1] == s[i])
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
            }

            if(count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
