using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_025___Matriz_resultante_de_outras_duas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Considere A e B matrizes 2 x 5. Faça um programa para calcular
             * a matriz C, resultante da soma da matriz A com a matriz B.
             * Imprimir a matriz C. */

            int[,] matrizA = new int[2, 5];
            int[,] matrizB = new int[2, 5];
            int[,] matrizC = new int[2, 5];

            Random numeroAleatorio = new Random();

            Console.WriteLine("Matriz A:");
            for (int m = 0; m < matrizA.GetLength(0); m++)
            {
                for (int n = 0; n < matrizA.GetLength(1); n++)
                {
                    matrizA[m, n] = numeroAleatorio.Next(1, 50);
                    Console.Write(matrizA[m, n] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz B:");
            for (int m = 0; m < matrizB.GetLength(0); m++)
            {
                for (int n = 0; n < matrizB.GetLength(1); n++)
                {
                    matrizB[m, n] = numeroAleatorio.Next(1, 50);
                    Console.Write(matrizB[m, n] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nA soma da matriz A e B gerando a Matriz C:");
            for (int m = 0; m < matrizC.GetLength(0); m++)
            {
                for (int n = 0; n < matrizC.GetLength(1); n++)
                {
                    matrizC[m, n] = matrizA[m, n] + matrizB[m, n];
                    Console.Write(matrizC[m, n] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
