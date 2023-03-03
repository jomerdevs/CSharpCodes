using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodes.Algorithms
{
    internal class TowerOfHanoiAlgorithm
    {
        // EN: Algorithm to solve the tower of hanoi matemathical puzzle
        // ES: Algoritmo para resolver el problema matemático de la torre de hanoi

        public static void solveTowerOfHanoi(int n, char fromRod, char toRod, char tempRod)
        {
            if (n > 0)
            {
                solveTowerOfHanoi(n - 1, fromRod, tempRod, toRod);
                Console.WriteLine($"Mover disco desde la varilla {fromRod} hacia la varilla {toRod}");
                solveTowerOfHanoi(n - 1, tempRod, toRod, fromRod);
            }
        }
        /*
        ------ IMPLEMENTATION / IMPLEMENTACION ------

        char fromRod = 'A';
        char toRod = 'C';
        char tempRod = 'B';
        int totalDisks = 3;

        TowerOfHanoiAlgorithm.solveTowerOfHanoi(totalDisks, fromRod, toRod, tempRod);

        */
    }
}
