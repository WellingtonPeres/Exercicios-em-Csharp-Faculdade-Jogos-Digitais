using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_010___Qual_estado_o_time_pertence
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um algoritmo em C# que informe com base no nome
              de um time fornecido, se este trata-se de um time carioca,
              paulista ou de outro estado.*/

            string[] carioca = { "FLAMENGO", "VASCO" };
            string[] paulista = { "SÃO PAULO", "CORINTHIAS" };
            string[] para = { "REMO", "CASTANHAL" };

            Console.Write("Digite o nome de um time Qualquer: ");
            string nomeTime = Console.ReadLine().ToUpper().Trim();

            if (carioca.Contains(nomeTime))
            {
                Console.WriteLine($"{nomeTime} é um time Carioca.");
            }
            else if (paulista.Contains(nomeTime))
            {
                Console.WriteLine($"{nomeTime} é um time Paulista");
            }
            else if (para.Contains(nomeTime))
            {
                Console.WriteLine($"{nomeTime} é um time do Pará");
            }
            else
            {
                Console.WriteLine($"O {nomeTime} não existe na lista de times de nenhum estado.");
            }

            Console.ReadLine();
        }
    }
}
