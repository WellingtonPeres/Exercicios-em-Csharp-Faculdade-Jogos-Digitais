using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_018___Informar_quantidade_de_ímpares
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um algoritmo em C# que receba 5 números 
               inteiros e informe quantos são ímpares.*/

            int numerosEntrada = 1;
            int numerosImpares = 0;

            while (numerosEntrada <= 5)
            {
                Console.Write($"Digite o {numerosEntrada}º número: ");
                int numeroDigitado = int.Parse(Console.ReadLine());

                if (numeroDigitado % 2 == 1)
                {
                    numerosImpares++;
                }

                numerosEntrada++;
            }

            Console.WriteLine($"A quantidade de números ímpares são: {numerosImpares}");

            Console.ReadLine();
        }
    }
}
