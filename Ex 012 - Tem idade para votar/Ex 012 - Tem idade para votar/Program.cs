using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_012___Tem_idade_para_votar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escrever um programa em C# que possibilite ao usuário saber
             * se poderá votar em determinada eleição inserindo o ano de
             * nascimento e o ano da eleição desejada. Não é necessário
             * considerar o mês em que a pessoa nasceu.*/

            Console.Write("Digite o ano em que você nasceu: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano em que você quer votar: ");
            int anoEleicao = int.Parse(Console.ReadLine());
                
            int verificarIdadeUsuarioParaVotar = anoEleicao - anoNascimento;
            int idadeCorretaParaVotar = 18;
            if (verificarIdadeUsuarioParaVotar >= idadeCorretaParaVotar)
            {
                Console.WriteLine($"No ano de votação você terá {verificarIdadeUsuarioParaVotar} anos, então, poderá votar.");
            }
            else
            {
                Console.WriteLine($"No ano de votação você terá {verificarIdadeUsuarioParaVotar} anos, então, não poderá votar ainda.");
            }

            Console.ReadLine();
        }
    }
}
