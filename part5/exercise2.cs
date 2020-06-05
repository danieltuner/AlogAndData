using System;
using System.Collections.Generic;

namespace part5
{
    public class Connectivity
    {
        public int n;
        public List<int> visited;

        List<int>[] graph;

        public Connectivity(int n)
        {
           this.n = n;
           this.visited = new List<int>();
           this.graph = new List<int>[n + 1];
           for (int i = 1; i <= n; i++)
           {
               graph[i] = new List<int>();
           }
            
        }

        public void AddConnection(int a, int b)
        {
            this.graph[a].Add(b);
            this.graph[b].Add(a);   
        }

        public int Calculate(int x)
        {
            
            if (visited.Contains(x))
            {
                return 0;
            }
            visited.Add(x);
            foreach (int n in graph[x])
            {
                Calculate(n);
            }
            return visited.Count -1;
        }

    }
}