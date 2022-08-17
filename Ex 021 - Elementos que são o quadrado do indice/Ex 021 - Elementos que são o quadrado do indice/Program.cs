using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_021___Elementos_que_são_o_quadrado_do_indice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar uma array de 5 números inteiros, nos quais cada elemento
             * seja o quadrado do índice. 
             * - Acessar o elemento 2 do array
             * - Acessar o elemento 5 do array */

            int[] arrayMumeroQuadrado = new int[5];
            for (int i = 0; i < arrayMumeroQuadrado.Length; i++)
            {
                arrayMumeroQuadrado[i] = i * i;
            }

            Console.WriteLine($"O segundo elemento do array é: {arrayMumeroQuadrado[1]}");
            Console.WriteLine($"O quinto elemento do array é: {arrayMumeroQuadrado[4]}");

            Console.ReadLine();
        }
    }
}
