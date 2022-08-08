using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_015___Soma_dos_números_entre_1_e_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que imprima a soma
             * dos números de 1 até 1000. */

            int somarNumeros = 0;
            int numereoAtual = 0;

            for (int i = 1; i <= 1000; i++)
            {
                somarNumeros += i;
                Console.WriteLine($"Soma do {i}° elemento que é {numereoAtual} + {i} = {somarNumeros}");
                numereoAtual = somarNumeros;
            }

            Console.ReadLine();
        }
    }
}
