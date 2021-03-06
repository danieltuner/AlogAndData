using System;

namespace part6
{
    class Program
    {
        static void Main(string[] args)
        {
            BellmanFord s = new BellmanFord(5);
            s.AddRoad(1, 2, 7);
            s.AddRoad(2, 4, 2);
            s.AddRoad(1, 3, 6);
            s.AddRoad(3, 4, 5);
            s.AddRoad(4, 5, 3);
            Console.WriteLine(s.Calculate(1, 5)); // 12

            /*
            Dijkstra s = new Dijkstra(5);
            s.AddRoad(1, 2, 7);
            s.AddRoad(2, 4, 2);
            s.AddRoad(1, 3, 6);
            s.AddRoad(3, 4, 5);
            s.AddRoad(4, 5, 3);
            Console.WriteLine(s.Calculate(1, 5)); // 12
            */
            FloydWarshall t = new FloydWarshall(5);
            t.AddRoad(1, 2, 7);
            t.AddRoad(2, 4, 2);
            t.AddRoad(1, 3, 6);
            t.AddRoad(3, 4, 5);
            t.AddRoad(4, 5, 3);
            Console.WriteLine(t.Calculate(1, 5)); // 12
            /*
            ShortestPath s = new ShortestPath(5);
            s.AddRoad(1, 2, 7);
            s.AddRoad(2, 4, 2);
            s.AddRoad(1, 3, 6);
            s.AddRoad(3, 4, 5);
            s.AddRoad(4, 5, 3);
            s.Create(1, 5).ForEach(Console.Write); // 1245
            */

        }
    }
}