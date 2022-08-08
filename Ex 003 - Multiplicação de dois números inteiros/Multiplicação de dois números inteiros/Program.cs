using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicação_de_dois_números_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa em C# para representar um algoritmo que
             efetue a multiplicação de dois inteiros quaisquer.*/

            Console.Write("Digite o primeiro valor: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultadoMultiplicacao = numero1 * numero2;

            Console.WriteLine($"A multiplicação entre {numero1} e {numero2} é {resultadoMultiplicacao}.");

            Console.ReadLine();
        }
    }
}
