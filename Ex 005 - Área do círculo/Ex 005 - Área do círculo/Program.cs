using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_005___Área_do_círculo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa em C# que receba o valor
             de um raio e retorne a área do círculo.*/

            Console.Write("Digite um raio de sua preferência: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine($"A área do círculo é {3.14 * (raio * raio)}");

            Console.ReadLine();
        }
    }
}
