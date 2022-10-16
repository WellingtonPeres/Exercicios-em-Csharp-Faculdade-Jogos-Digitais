using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_028___Remover_números_negativos_de_uma_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que remova todos os números negativos
             * de uma lista de números inteiros inseridas pelo usuário. */

            int numeroUsuario;
            List<int> todosNumeros = new List<int>();
            List<int> somenteNumerosPositivos = new List<int>();

            string condicaoParada = "";
            while (condicaoParada != "S")
            {
                Console.Write("Digite qualquer número. Obs.: pode der negativo ou positivo: ");
                numeroUsuario = int.Parse(Console.ReadLine());
                todosNumeros.Add(numeroUsuario);

                Console.Write("Deseja sair? Digite [S] para sair ou [N] para continuar: ");
                condicaoParada = Console.ReadLine().ToUpper();

                //Console.Clear();
            }
            for (int i = 0; i < todosNumeros.Count; i++)
            {
                if (todosNumeros[i] > 0)
                {
                    somenteNumerosPositivos.Add(todosNumeros[i]);
                }
            }
            Console.Write("Programa finalizado com sucesso!");

            Console.Write("\nLista com todos números: ");
            foreach (int item in todosNumeros)
            {
                Console.Write($"[{item}] ");
            }

            Console.Write("\nA lista com os valores positivos é: ");
            foreach (int item in somenteNumerosPositivos)
            {
                Console.Write($"[{item}] ");
            }

            Console.ReadLine();
        }
    }
}
