using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_008___Calcular_o_valor_do_bônus
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A empresa ACME Ltda. concedeu um bônus de 20% (por cento) do
              valor do salário a todos os funcionários com tempo de trabalho
              na empresa igual ou superior a cinco anos e de 10% (por cento)
              aos demais. Calcular e exibir o valor do bônus.*/

            Console.Write("Digite o tempo de serviço do funcionário: ");
            int tempoTrabalho = int.Parse(Console.ReadLine());
            Console.Write("Digite o salário do funcionário: R$ ");
            float salario = float.Parse(Console.ReadLine());

            float bonus20 = salario + (salario * 20 / 100);
            float bonus10 = salario + (salario * 10 / 100);

            if (tempoTrabalho >= 5)
            {
                Console.WriteLine($"Para quem tem mais de 4 anos na empresa. Bônus de 20%: R$ {bonus20}");
            }
            else
            {
                Console.WriteLine($"Para quem tem menos de 5 anos na empresa. Bônus de 10%: R$ {bonus10}");
            }

            Console.ReadLine();
        }
    }
}
