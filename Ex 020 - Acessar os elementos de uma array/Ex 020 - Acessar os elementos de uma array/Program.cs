using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_020___Acessar_os_elementos_de_uma_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar uma array com os nomes dos dias da semana e acessar os elementos. */

            string[] diasSemana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            Console.Write("Digite um número de 1 a 7 que corresponda ao dia da semana: ");
            int digitarNumeroDiaSemana = int.Parse(Console.ReadLine());
            switch (digitarNumeroDiaSemana) 
            {
                case 1:
                    Console.WriteLine($"O primeiro dia da semana é: {diasSemana[digitarNumeroDiaSemana - 1]}");
                    break;
                case 2:
                    Console.WriteLine($"O segundo dia da semana é: {diasSemana[digitarNumeroDiaSemana - 1]}");
                    break;
                case 3:
                    Console.WriteLine($"O terceiro dia da semana é: {diasSemana[digitarNumeroDiaSemana - 1]}");
                    break;
                case 4:
                    Console.WriteLine($"O quarto dia da semana é: {diasSemana[digitarNumeroDiaSemana - 1]}");
                    break;
                case 5:
                    Console.WriteLine($"O quinto dia da semana é: {diasSemana[digitarNumeroDiaSemana - 1]}");
                    break;
                case 6:
                    Console.WriteLine($"O sexto dia da semana é: {diasSemana[digitarNumeroDiaSemana - 1]}");
                    break;
                case 7:
                    Console.WriteLine($"O setimo dia da semana é: {diasSemana[digitarNumeroDiaSemana - 1]}");
                    break;
                default:
                    Console.WriteLine("O valor informado não existe.");
                    break;
            }  

            Console.ReadLine();
        }
    }
}
