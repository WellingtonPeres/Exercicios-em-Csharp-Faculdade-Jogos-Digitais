using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_022___Soma_entre_o_maior_e_meno_número
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ler uma array com 10 inteiros e somar o maior e
             * o menor elemento do array. */
            int[] numerosAleatorios = new int[10];
            Random randomico = new Random();

            #region Usando Min e Max do C#
            for (int i = 0; i < 10; i++)
            {
                numerosAleatorios[i] = randomico.Next(1, 50);
                Console.WriteLine(numerosAleatorios[i]);
            }

            int menorNumero = numerosAleatorios.Min();
            int maiorNumero = numerosAleatorios.Max();
            int somaNumeros = menorNumero + maiorNumero;

            Console.WriteLine($"O menor número é: {menorNumero}");
            Console.WriteLine($"O maior número é: {maiorNumero}");
            Console.WriteLine($"A soma do menor número com o maior número é: {somaNumeros}");
            #endregion

            #region Fazendo por conta própria
            int numeroRandomico = randomico.Next(1, 50);
            int menorNumero2 = numeroRandomico;
            int maiorNumero2 = numeroRandomico;
            numerosAleatorios[0] = numeroRandomico;

            Console.WriteLine(numerosAleatorios[0]);

            for (int i = 1; i < 10; i++)
            {
                numerosAleatorios[i] = randomico.Next(1, 50);
                Console.WriteLine(numerosAleatorios[i]);

                if (numerosAleatorios[i] <= menorNumero2)
                {
                    menorNumero2 = numerosAleatorios[i];
                }
                if (numerosAleatorios[i] >= maiorNumero2)
                {
                    maiorNumero2 = numerosAleatorios[i];
                }
            }

            int somaNumeros2 = menorNumero2 + maiorNumero2;

            Console.WriteLine($"O menor número é: {menorNumero2}");
            Console.WriteLine($"O maior número é: {maiorNumero2}");
            Console.WriteLine($"A soma do menor número com o maior número é: {somaNumeros2}");
            #endregion

            Console.ReadLine();
        }
    }
}
