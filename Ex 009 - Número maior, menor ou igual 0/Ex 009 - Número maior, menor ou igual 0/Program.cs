using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_009___Número_maior__menor_ou_igual_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um algoritmo em C# para determinar
              se um número é maior, menor ou igual a zero.*/

            Console.Write("Digite um número maior, menor ou igual a zero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine($"O número digitado '{numero}' é maior que [0].");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"O número digitado '{numero}' é menor que [0].");
            }
            else
            {
                Console.WriteLine($"O número digitado '{numero}' é igual a [0].");
            }

            Console.ReadLine();
        }
    }
}
