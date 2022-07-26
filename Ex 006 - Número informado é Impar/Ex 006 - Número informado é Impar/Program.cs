using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_006___Número_informado_é_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um algoritmo em C# que verifique se um número
              fornecido pelo usuário é ímpar. Se for, exibir a mensagem:
              "O número informado é ímpar".*/

            Console.Write("Digite um número Ímpar: ");
            int numeroUsuario = int.Parse(Console.ReadLine());

            if (numeroUsuario % 2 == 1)
            {
                Console.WriteLine("O número informado é ímpar.");
            }
            else
            {
                Console.WriteLine("O número informado não é ímpar.");
            }

            Console.ReadLine();
        }
    }
}
