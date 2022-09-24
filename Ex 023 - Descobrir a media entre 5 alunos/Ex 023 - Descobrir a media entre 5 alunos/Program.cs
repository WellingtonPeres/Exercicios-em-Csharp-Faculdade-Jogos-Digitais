using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_023___Descobrir_a_media_entre_5_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um programa deve ler a nota de 5 alunos e depois exibir as
             * notas fornecidas, bem como a média entre elas.
             * DICA: Utilizar um array para armazenar as notas. */

            float[] notas = new float[5];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a nota do {i + 1}º aluno: ");
                float nota = float.Parse(Console.ReadLine());
                notas[i] = nota;
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("As notas de todos os alunos são:");
            int indexAtual = 1;
            foreach (float index in notas)
            {
                Console.WriteLine($"A nota do {indexAtual} é: {index}");
                indexAtual++;
            }

            Console.WriteLine("----------------------------------");

            float somaNotas = 0;
            float mediaNotas;
            for (int i = 0; i < notas.Length; i++)
            {
                somaNotas += notas[i];
            }
            mediaNotas = somaNotas / notas.Length;
            Console.WriteLine($"A soma de todas as notas é: {somaNotas}:\nE a média entre elas é: {mediaNotas}");

            Console.ReadLine();
        }
    }
}
