using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_031___Retornar_o_maior_valor_da_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar um método que receba um array de números inteiros e
             * imprima o maior valor existente. */

            int[] numerosArray = new int[] { 1, 2, 6, 10, 100, 50, 15, 38, 5, 60 };

            Console.WriteLine($"O maior número da array usando o método MAX() é: {numerosArray.Max()}");
            Console.WriteLine($"O maior número da array com método manual é: {RetornarMaiorNumeroDeUmaArray(numerosArray)}");

            Console.ReadLine();
        }

        public static int RetornarMaiorNumeroDeUmaArray(int[] numeros)
        {
            int maiorNumero = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
            }

            return maiorNumero;
        }
    }
}
