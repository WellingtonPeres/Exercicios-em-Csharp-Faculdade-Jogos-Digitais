using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_024___Criar_uma_matriz_3_x_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar uma matriz 3 x 3 pré-configurada e imprimir os valores: */

            int[,] matriz = new int[3, 3];

            matriz[0, 0] = 1;
            matriz[0, 1] = 5;
            matriz[0, 2] = 3;

            matriz[1, 0] = 2;
            matriz[1, 1] = 4;
            matriz[1, 2] = 8;

            matriz[2, 0] = 9;
            matriz[2, 1] = 0;
            matriz[2, 2] = 6;

            for (int m = 0; m < matriz.GetLength(0); m++)
            {
                for (int n = 0; n < matriz.GetLength(1); n++)
                {
                    Console.Write(matriz[m, n] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
