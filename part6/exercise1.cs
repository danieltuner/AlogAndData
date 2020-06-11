using System;
using System.Collections.Generic;

namespace part6
{
    public class Edge
    {
        public int beginning, end, weight;
        public Edge(int beginning, int end, int weight)
        {
            this.beginning = beginning;
            this.end = end;
            this.weight = weight;
        }        
    }
    public class BellmanFord
    {
        public int n;
        public List<Edge> edges;

        

        public BellmanFord(int n)
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
            int[] distance = new int[n+1];
            for (int i = 0; i < n+1; i++)
            {
                distance[i] = int.MaxValue;
            }
            distance[x] = 0;

            while (true)
            {
                bool change = false;

                foreach (Edge i in edges)
                {
                    int current = distance[i.end];
                    int newCurrent = distance[i.beginning] + i.weight;

                    if (newCurrent < current)
                    {
                        distance[i-end] = newCurrent;
                        change = true;
                    }
                }
                if (change == false)
                {
                    break;
                }
            }
            return distance[y];
        }
    }
}
/*
while true
  change = false
  for edge in edges
    current = distance[edge.end]
    new = distance[edge.source]+edge.weight
    if new < current
      distance[edge.end] = new
      change = true
  if not change
    break
*/