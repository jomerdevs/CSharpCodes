using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodes.Algorithms
{
    internal class DijkstraAlgorithm
    {
        // EN: Dijkstra Algorithm for determining the shortest path
        // ES: Algoritmo Dijkstra para determinar la ruta más corta

        private static int DistanciaMinima(int[] distancia, bool[] conjuntoDeArbolesRutaMasCorta, int contarVertices)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < contarVertices; ++v)
            {
                if (conjuntoDeArbolesRutaMasCorta[v] == false && distancia[v] <= min)
                {
                    min = distancia[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private static void Print(int[] distancia, int contarVertices)
        {
            Console.WriteLine("Vertice   Distancia de la fuente");

            for (int i = 0; i < contarVertices; ++i)
            {
                Console.WriteLine("{0}\t  {1}", i, distancia[i]);
            }
        }

        public static void solveDijkstraAlgorithm(int[,] graph, int fuente, int contarVertices)
        {
            int[] distancia = new int[contarVertices];
            bool[] conjuntoDeArbolesRutaMasCorta = new bool[contarVertices];

            for (int i = 0; i < contarVertices; ++i)
            {
                distancia[i] = int.MaxValue;
                conjuntoDeArbolesRutaMasCorta[i] = false;
            }

            distancia[fuente] = 0;

            for (int count = 0; count < contarVertices - 1; ++count)
            {
                int u = DistanciaMinima(distancia, conjuntoDeArbolesRutaMasCorta, contarVertices);
                conjuntoDeArbolesRutaMasCorta[u] = true;

                for (int v = 0; v < contarVertices; ++v)
                    if (!conjuntoDeArbolesRutaMasCorta[v] && Convert.ToBoolean(graph[u, v]) && distancia[u] != int.MaxValue && distancia[u] + graph[u, v] < distancia[v])
                        distancia[v] = distancia[u] + graph[u, v];
            }

            Print(distancia, contarVertices);
        }
        /*
         ------ IMPLEMENTATION / IMPLEMENTACION ------
        
         int[,] graph =  {
                         { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
                         { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
                         { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
                         { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
                         { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                         { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
                         { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
                         { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
                         { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
                            };

        DijkstraAlgorithm.solveDijkstraAlgorithm(graph, 0, 9);

        */
    }

}
