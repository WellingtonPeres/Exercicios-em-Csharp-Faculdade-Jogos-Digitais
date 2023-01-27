using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_029___Criar_um_método_que_retorna_seu_nome
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar um método que imprima na tela o nome de uma pessoa
             * - Identifique a assinatura do método criado.
             * - Identifique o retorno do método criado. */

            Console.Write("Escreva um nome qualquer: ");
            string nome = Console.ReadLine();

            Console.WriteLine(RetornarNomePessoa(nome));

            Console.ReadLine();
        }

        public static string RetornarNomePessoa(string nome)
        {
            return nome;
        }
    }
}
