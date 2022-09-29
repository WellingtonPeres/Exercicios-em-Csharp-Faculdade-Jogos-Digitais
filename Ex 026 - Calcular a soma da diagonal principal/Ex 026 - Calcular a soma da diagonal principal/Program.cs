using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_026___Calcular_a_soma_da_diagonal_principal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ler uma matriz 4 x 4 e calcular a soma dos elementos
             * da diagonal principal. */

            int[,] matriz = new int[4, 4];
            int somaDiagonalPrincipal = 0;

            Random numeroAleatorio = new Random();
            for (int m = 0; m < matriz.GetLength(0); m++)
            {
                for (int n = 0; n < matriz.GetLength(1); n++)
                {
                    matriz[m, n] = numeroAleatorio.Next(1, 50);
                    Console.Write(matriz[m, n] + " ");

                    if (m == n)
                    {
                        somaDiagonalPrincipal += matriz[m, n];
                    }
                }

                Console.WriteLine();
            }
            Console.Write($"\nA soma da diagonal principal é: [{somaDiagonalPrincipal}]");

            Console.ReadLine();
        }
    }
}
