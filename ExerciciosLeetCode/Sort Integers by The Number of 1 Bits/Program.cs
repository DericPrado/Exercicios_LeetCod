using System.Runtime.CompilerServices;

namespace Sort_Integers_by_The_Number_of_1_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Segue o link do desafio: https://leetcode.com/problems/sort-integers-by-the-number-of-1-bits/description/?envType=daily-question&envId=2026-02-25
             */
        }

        public static int[] SortByBits(int[] arr)
        {
            string binaries = "";
            List<BinariesPosition> binariesPositions = new List<BinariesPosition>();

            for (int i = 0; i < arr.Length; i++)
            {
                binaries = Convert.ToString(arr[i], 2);
                binariesPositions.Add(new BinariesPosition
                {
                    Integer = arr[i],
                    Position = i,
                    Value = binaries,
                    Ones = binaries.Count(l => l == '1')
                });
                
            }

            return binariesPositions.OrderBy(x => x.Ones)
                .ThenBy(x => x.Integer)
                .Select(x => x.Integer)
                .ToArray();
        }

        public class BinariesPosition
        {
            public int Integer {  get; set; }
            public int Position {  get; set; }
            public string Value { get; set; }
            public int Ones { get; set; }
        }
    }
}
