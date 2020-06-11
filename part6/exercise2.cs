using System;

namespace part6
{
    public class Dijkstra
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
Dijkstra(graph, source):
  
  for each node in graph
    dist[node] = infinity	
    previous[node] = undefined	
  
  dist[source] = 0
  
  Q = the set of all nodes in graph
  
  while Q is not empty
    n = node in Q with smallest dist[]
    remove n from Q
    
    for each neighbor of n
      alt = dist[n] + dist_between(n, neighbor)
      if alt < dist[neighbor]	
        dist[neighbor] = alt
        previous[neighbor] = n
	
  return previous[]
*/