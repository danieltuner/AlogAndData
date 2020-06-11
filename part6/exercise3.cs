using System;

namespace part6
{
    public class FloydWarshall
    {
        public int n;
        public ShortestPath(int n)
        {
            this.n = n;
        }

        public void AddRoad(int a, int b, int d)
        {

        }

        public int Calculate(int x, int y)
        {
            return 0;
        }
    }
}
/*
for k = 1 to n
  for i = 1 to n
    for j = 1 to n
      distance[i,j] = min(distance[i,j], distance[i,k]+distance[k,j])
*/