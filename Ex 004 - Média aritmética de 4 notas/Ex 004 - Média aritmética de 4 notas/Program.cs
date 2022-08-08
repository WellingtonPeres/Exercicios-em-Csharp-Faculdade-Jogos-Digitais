using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_004___Média_aritmética_de_4_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa em C# que receba 4 notas,
             * calcule e mostre a média aritmética entre elas.*/

            Console.Write("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());
            Console.Write("Digite a quarta nota: ");
            float nota4 = float.Parse(Console.ReadLine());

            float mediaAritmética = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"A média aritmética do aluno é {mediaAritmética}");
            Console.ReadLine();
        }
    }
}
