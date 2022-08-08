using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_011___Média_entre_5_números
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um algoritmo em C# que receba 5 números
              fornecidos pelo usuário e calcule a média entre eles.*/

            Console.Write("Digite o 1° valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 2° valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 3° valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 4° valor: ");
            int valor4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 5° valor: ");
            int valor5 = Convert.ToInt32(Console.ReadLine());

            int somarValores = valor1 + valor2 + valor3 + valor4 + valor5;
            float media = somarValores / 5;
            Console.WriteLine($"A soma dos valores é: {somarValores}");
            Console.WriteLine($"A média dos valores fornecidos é: {media}");

            Console.ReadLine();
        }
    }
}
