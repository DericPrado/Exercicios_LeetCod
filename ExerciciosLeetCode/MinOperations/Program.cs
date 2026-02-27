using System.Text;

namespace MinOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Link do desafio: https://leetcode.com/problems/minimum-operations-to-equalize-binary-string/?envType=daily-question&envId=2026-02-27
             */
        }

        public int MinOperations(string s, int k)
        {
            int n = s.Length;
            int zeros = s.Count(x => x == '0');

            if (zeros == 0) return 0;

            int[] dist = new int[n + 1];
            Array.Fill(dist, -1);
            dist[zeros] = 0;

            Queue<int> q = new Queue<int>();
            q.Enqueue(zeros);

            int[] parent = new int[n + 3];
            for (int i = 0; i < parent.Length; i++)
            {
                parent[i] = i;
            }

            parent[zeros] = zeros + 2;

            int Find(int i)
            {
                int curr = i;
                while (curr != parent[curr])
                {
                    parent[curr] = parent[parent[curr]];
                    curr = parent[curr];
                }
                return curr;
            }

            while (q.Count > 0)
            {
                int curr = q.Dequeue();
                int passosAteAqui = dist[curr];

                int minX = Math.Max(0, k - (n - curr));
                int maxX = Math.Min(curr, k);

                int L = curr - 2 * maxX + k;
                int R = curr - 2 * minX + k;

                for (int v = Find(L); v <= R; v = Find(v))
                {
                    dist[v] = passosAteAqui + 1;

                    if (v == 0) return dist[v];

                    q.Enqueue(v);
                    parent[v] = v + 2;
                }
            }

            return -1;

        }
    }
}
