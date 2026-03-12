namespace Maximize_Spanning_Tree_Stability_with_Upgrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 Segue o link: https://leetcode.com/problems/maximize-spanning-tree-stability-with-upgrades/description/?envType=daily-question&envId=2026-03-12
             */
        }

        public int MaxStability(int n, int[][] edges, int k)
        {
            DSU initialCheck = new DSU(n);
            int mandatoryEdgesCount = 0;
            int totalEdgesCount = 0;

            foreach (var edge in edges)
            {
                if (edge[3] == 1)
                {
                    if (!initialCheck.Union(edge[0], edge[1])) return -1;
                    mandatoryEdgesCount++;
                }
            }

            DSU connCheck = new DSU(n);
            foreach (var edge in edges)
            {
                if (connCheck.Union(edge[0], edge[1])) totalEdgesCount++;
            }
            if (totalEdgesCount < n - 1) return -1;

            int left = 0;
            int right = 0;

            foreach (var edge in edges)
            {
                int potentialStrength = edge[3] == 1 ? edge[2] : edge[2] * 2;
                right = Math.Max(right, potentialStrength);
            }

            int bestStability = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (CanFormTree(n, edges, k, mid))
                {
                    bestStability = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return bestStability;
        }

        class DSU
        {
            private int[] parent;

            public DSU(int n)
            {
                parent = new int[n];
                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
                }
            }

            public int Find(int i)
            {
                if (parent[i] == i) return i;
                return parent[i] = Find(parent[i]);
            }

            public bool Union(int i, int j)
            {
                int rootI = Find(i);
                int rootJ = Find(j);

                if (rootI != rootJ)
                {
                    parent[rootI] = rootJ;
                    return true;
                }
                return false;
            }
        }

        private bool CanFormTree(int n, int[][] edges, int k, long target)
        {
            DSU dsu = new DSU(n);
            int edgesUsed = 0;
            int upgradesUsed = 0;

            foreach (var edge in edges)
            {
                if (edge[3] == 1)
                {
                    if (edge[2] < target) return false;
                    dsu.Union(edge[0], edge[1]);
                    edgesUsed++;
                }
            }

            foreach (var edge in edges)
            {
                if (edge[3] == 0 && edge[2] >= target)
                {
                    if (dsu.Union(edge[0], edge[1]))
                    {
                        edgesUsed++;
                    }
                }
            }

            foreach (var edge in edges)
            {
                if (edge[3] == 0 && edge[2] < target && (long)edge[2] * 2 >= target)
                {
                    if (dsu.Union(edge[0], edge[1]))
                    {
                        edgesUsed++;
                        upgradesUsed++;
                    }
                }
            }

            return edgesUsed == n - 1 && upgradesUsed <= k;
        }
    }
}
