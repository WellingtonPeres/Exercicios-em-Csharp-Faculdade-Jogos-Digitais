using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_007___Divisão_de_dois_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um algoritmo em C# para obter o resultado
              da divisão de dois números inteiros quaisquer.*/
            Console.Write("Digite um número qualquer: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número qualquer: ");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = numero1 / numero2;

            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.ReadLine();
        }
    }
}
