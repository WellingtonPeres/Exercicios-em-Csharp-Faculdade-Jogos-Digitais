using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_030___Maior_número_entre_dois_parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar um método que receba dois números inteiros como 
             * argumento e imprima o maior deles. */

            Console.WriteLine("Digite dois números para saber qual é o maior entre eles!!!");

            Console.Write("Digite o 1º número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine($"O maior número é: {RetornarMaiorVanlorEntreDoisNumeros(primeiroNumero, segundoNumero)}");

            Console.ReadLine();
        }

        public static int RetornarMaiorVanlorEntreDoisNumeros(int numero1, int numero2)
        {
            int maiorNumero = 0;

            if (numero1 > numero2)
            {
                maiorNumero = numero1;
            }
            else
            {
                maiorNumero = numero2;
            }

            return maiorNumero;
        }
    }
}
