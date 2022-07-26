using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acrescentando_mais_unidades_a_um_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa em C# que recebe um valor
             * inteiro, acrescente duas unidades a este, e exiba
             * o resultado desta manipulação.*/
            int numero = 8;
            int acrescentar = numero + 2;
            Console.WriteLine($"A soma entre os dois valores é: {acrescentar}");

            int numero2 = int.Parse(Console.ReadLine());
            int acrescentar2 = 2;
            Console.WriteLine($"A soma entre {numero2} e {acrescentar2} é: {numero2 + acrescentar2}");

            Console.ReadLine();

        }
    }
}
