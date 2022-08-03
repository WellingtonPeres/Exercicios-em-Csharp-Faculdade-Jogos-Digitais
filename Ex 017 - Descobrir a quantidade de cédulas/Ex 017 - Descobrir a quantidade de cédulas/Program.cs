using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_017___Descobrir_a_quantidade_de_cédulas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa que leia um número inteiro
             * e calcule a quantidade mínima de cédulas de dinheiro
             * que o valor possa ser decomposto. Os valores possíveis
             * das cédulas são: 100, 50, 20, 10, 5, 2, 1.
             * Deve ser impressa a quantidade de cada cédula.*/

            Console.Write("Digite um valor qualquer em R$: ");
            int digitarNumero = int.Parse(Console.ReadLine());
            int numeroDigitado = digitarNumero;
            Console.WriteLine("--------------------------------------------------");

            int quantidadeCedulas100 = numeroDigitado / 100;
            numeroDigitado -= quantidadeCedulas100 * 100;
            Console.WriteLine($"Quantidade de cédulas de 100: {quantidadeCedulas100}");
            Console.WriteLine($"Restante do valor digitado: {numeroDigitado}");
            Console.WriteLine("--------------------------------------------------");

            int quantidadeCedulas50 = numeroDigitado / 50;
            numeroDigitado -= quantidadeCedulas50 * 50;
            Console.WriteLine($"Quantidade de cédulas de 50: {quantidadeCedulas50}");
            Console.WriteLine($"Restante do valor digitado: {numeroDigitado}");
            Console.WriteLine("--------------------------------------------------");

            int quantidadeCedulas20 = numeroDigitado / 20;
            numeroDigitado -= quantidadeCedulas20 * 20;
            Console.WriteLine($"Quantidade de cédulas de 20: {quantidadeCedulas20}");
            Console.WriteLine($"Restante do valor digitado: {numeroDigitado}");
            Console.WriteLine("--------------------------------------------------");

            int quantidadeCedulas10 = numeroDigitado / 10;
            numeroDigitado -= quantidadeCedulas10 * 10;
            Console.WriteLine($"Quantidade de cédulas de 10: {quantidadeCedulas10}");
            Console.WriteLine($"Restante do valor digitado: {numeroDigitado}");
            Console.WriteLine("--------------------------------------------------");

            int quantidadeCedulas5 = numeroDigitado / 5;
            numeroDigitado -= quantidadeCedulas5 * 5;
            Console.WriteLine($"Quantidade de cédulas de 5: {quantidadeCedulas5}");
            Console.WriteLine($"Restante do valor digitado: {numeroDigitado}");
            Console.WriteLine("--------------------------------------------------");

            int quantidadeCedulas2 = numeroDigitado / 2;
            numeroDigitado -= quantidadeCedulas2 * 2;
            Console.WriteLine($"Quantidade de cédulas de 2: {quantidadeCedulas2}");
            Console.WriteLine($"Restante do valor digitado: {numeroDigitado}");
            Console.WriteLine("--------------------------------------------------");

            int quantidadeCedulas1 = numeroDigitado / 1;
            numeroDigitado -= quantidadeCedulas1 * 1;
            Console.WriteLine($"Quantidade de cédulas de 1: {quantidadeCedulas1}");
            Console.WriteLine($"Restante do valor digitado: {numeroDigitado}");
            Console.WriteLine("--------------------------------------------------");

            Console.ReadLine();
        }
    }
}
