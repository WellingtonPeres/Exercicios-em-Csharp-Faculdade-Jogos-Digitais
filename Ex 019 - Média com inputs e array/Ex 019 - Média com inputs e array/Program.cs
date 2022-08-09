using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_019___Média_com_inputs_e_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa-exemplo em C# usando variáveis
             * para as seguintes tarefas:
             * 1-> Média de 5 números fornecidos pelo usuário;
             * 2-> Média de 5 números utilizando array de inteiros.*/

            #region 1 -> Imput do usuário
            /*
            int numerosDigitados;
            int somarNumerosDigitados = 0;
            int mediaNumerosDigitados;

            Console.WriteLine("Digite 5 números para encontrar a média entre eles: \n");
            int quantidadeRepeticao = 5;
            while (quantidadeRepeticao >= 1)
            {
                Console.Write($"Digite {quantidadeRepeticao}º número: ");
                numerosDigitados = int.Parse(Console.ReadLine());
                somarNumerosDigitados += numerosDigitados;

                quantidadeRepeticao--;
            }

            mediaNumerosDigitados = somarNumerosDigitados / 5;
            Console.WriteLine($"\nA soma dos números digitados foi: {somarNumerosDigitados}.");
            Console.WriteLine($"A média dos números digitados é: {mediaNumerosDigitados}.");
            */
            #endregion

            #region 2 -> Array aleatório
            int[] arrayNumerosInteiros = new int[5];// 0, 1, 2, 3, 4
            Random numerosAleatorios = new Random();
            for (int i = 0; i < 5; i++)
            {
                arrayNumerosInteiros[i] = numerosAleatorios.Next(0, 50);
                Console.WriteLine($"Números {i + 1}º aleatório foi: {arrayNumerosInteiros[i]}");
            }

            int somaArray = 0;
            int mediaArray = 0;
            for (int i = 0; i < arrayNumerosInteiros.Length; i++)
            {
                somaArray += arrayNumerosInteiros[i];
            }

            Console.WriteLine($"\nA soma dos números da array é: {somaArray}");
            mediaArray = somaArray / arrayNumerosInteiros.Length;
            Console.WriteLine($"{mediaArray}");
            #endregion

            Console.ReadLine();
        }
    }
}
