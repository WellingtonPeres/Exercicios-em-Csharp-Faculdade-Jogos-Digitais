using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_014___Imprimir_inteiros_de_um_intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Implemente um programa que imprima os números
             * inteiros contidos no intervalo [1, 10]. */
            int numeros;

            for (int i = 1; i <= 10; i++)
            {
                numeros = i;
                Console.WriteLine(numeros);
            }

            Console.ReadLine();
        }
    }
}
