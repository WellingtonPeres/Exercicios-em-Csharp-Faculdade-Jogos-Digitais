using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_013___Solicitar_a_operação_desejada
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar um programa que leia dois números inteiros, e que solicite
             * ao usuário qual a operação deseja realizar entre esses números.
             * Caso o usuário digitar os caracteres:
             * "*" será realizada uma multiplicação;
             * "/" será realizada uma divisão;
             * "+" será realizada uma adição;
             * "-" será realizada uma subtração. */

            Console.Write("Digite o primerio número da operação: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número da operação: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resultado;

            Console.Write("Digite a operação desejada [*] [/] [+] [-]: ");
            string operacaoDesejada = Console.ReadLine();

            #region Condicional if
            //if (operacaoDesejada == "*")
            //{
            //    resultado = primeiroNumero * segundoNumero;
            //    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            //}
            //if (operacaoDesejada == "/")
            //{
            //    resultado = primeiroNumero / segundoNumero;
            //    Console.WriteLine($"O resultado da divisão é: {resultado}");
            //}
            //if (operacaoDesejada == "+")
            //{
            //    resultado = primeiroNumero + segundoNumero;
            //    Console.WriteLine($"O resultado da adição é: {resultado}");
            //}
            //if (operacaoDesejada == "-")
            //{
            //    resultado = primeiroNumero - segundoNumero;
            //    Console.WriteLine($"O resultado da subtração é: {resultado}");
            //}
            #endregion

            #region Condicional switch case
            switch (operacaoDesejada)
            {
                case "*":
                    resultado = primeiroNumero * segundoNumero;
                    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                    break;
                case "/":
                    resultado = primeiroNumero / segundoNumero;
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                    break;
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    Console.WriteLine($"O resultado da adição é: {resultado}");
                    break;
                case "-":
                    resultado = primeiroNumero - segundoNumero;
                    Console.WriteLine($"O resultado da subtração é: {resultado}");
                    break;
                default:
                    Console.WriteLine($"A operação que você digitou não existe");
                    break;
            }
            #endregion

            Console.ReadLine();
        }
    }
}
