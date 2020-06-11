using System;
using System.Collections.Generic;

namespace part6
{
    public class FloydWarshall
    {
        public int n;
        public List<Edge> edges;
        public FloydWarshall(int n)
        {
            this.n = n;
            this.edges = new List<Edge>();
        }

        public void AddRoad(int a, int b, int d)
        {
            this.edges.Add(new Edge(a, b, d));
        }

        public int Calculate(int x, int y)
        {
            int[,] distance = new int[n+1, n+1];
            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < n+1; j++)
                {
                    if (i == j)
                    {
                        distance[i, j] = 0;
                    }
                    else
                    {
                        distance[i, j] = int.MaxValue;
                    }
                }
            }

            for (int k = 1; k < n+1; k++)
            {
                for (int i = 1; i < n+1; i++)
                {
                    for (int j = 1; j < n+1; j++)
                    {
                        distance[i, j] = Math.Min(distance[i, j], distance[i, k] + distance[k, j]);
                    }
                }
            }
            return distance[x, y];
        }
    }
}
/*
for k = 1 to n
  for i = 1 to n
    for j = 1 to n
      distance[i,j] = min(distance[i,j], distance[i,k]+distance[k,j])
*/