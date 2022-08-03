using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_016___Múltiplos_de_3_entre_1_e_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa em C# que imprima
              todos os múltiplos de 3, entre 1 e 100.*/

            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
