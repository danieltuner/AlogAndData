using System;

namespace part6
{
    public class BellmanFord
    {
        public int n;
        public List<Edge> edges;
        public ShortestPath(int n)
        {
            this.n = n;
            this.edges = new List<Edge>();
        }

        public void AddRoad(int a, int b, int d)
        {
            this.edges.Add(new Edge(a, b, d));
            this.edges.Add(new Edge(b, a, d));
        }

        public int Calculate(int x, int y)
        {
            return 0;
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