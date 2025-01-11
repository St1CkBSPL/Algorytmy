using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djikstry
{
    public class Graph
    {
        private int wierzcholki;
        private List<Tuple<int, int>>[] listaSasiadow;

        public Graph(int wierzcholki)
        {
            this.wierzcholki = wierzcholki;
            listaSasiadow = new List<Tuple<int, int>>[wierzcholki];
            for (int i = 0; i < wierzcholki; i++)
            {
                listaSasiadow[i] = new List<Tuple<int, int>>();
            }
        }

        public void AddEdge(int u, int v, int weight)
        {
            listaSasiadow[u].Add(new Tuple<int, int>(v, weight));
            listaSasiadow[v].Add(new Tuple<int, int>(u, weight)); // Jeśli graf jest nieskierowany
        }

        public int[] Dijkstra(int start)
        {
            int[] distances = new int[wierzcholki];
            bool[] shortestPathSet = new bool[wierzcholki];

            for (int i = 0; i < wierzcholki; i++)
            {
                distances[i] = int.MaxValue;
                shortestPathSet[i] = false;
            }

            distances[start] = 0;

            for (int count = 0; count < wierzcholki - 1; count++)
            {
                int u = MinDistance(distances, shortestPathSet);
                shortestPathSet[u] = true;

                for (int v = 0; v < wierzcholki; v++)
                {
                    foreach (var neighbor in listaSasiadow[u])
                    {
                        if (!shortestPathSet[v] && distances[u] != int.MaxValue && distances[u] + neighbor.Item2 < distances[neighbor.Item1])
                        {
                            distances[neighbor.Item1] = distances[u] + neighbor.Item2;
                        }
                    }
                }
            }

            return distances;
        }

        private int MinDistance(int[] distances, bool[] shortestPathSet)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < wierzcholki; v++)
            {
                if (!shortestPathSet[v] && distances[v] <= min)
                {
                    min = distances[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
    }
}
