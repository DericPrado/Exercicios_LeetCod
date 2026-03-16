namespace Maximum_Number_of_Distinct_Elements_After_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Segue o link do desafio: https://leetcode.com/problems/maximum-number-of-distinct-elements-after-operations/?envType=daily-question&envId=2026-03-16
             */
        }

        public int MaxDistinctElements(int[] nums, int k)
        {
            Array.Sort(nums);

            int elementosDistintos = 0;

            long ultimoAtribuido = long.MinValue;

            foreach (int num in nums)
            {
                long candidato = Math.Max(ultimoAtribuido + 1, (long)num - k);

                if (candidato <= (long)num + k)
                {
                    elementosDistintos++;
                    ultimoAtribuido = candidato;
                }
            }

            return elementosDistintos;
        }
    }
}
