using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExContribuinte.Entitites;

namespace ExContribuinte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Console.Write("entre com o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());  

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados do contribuinte #{i} ");
                Console.Write("Pessoa Física ou jurídica? (f ou j) ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if (ch == 'f')
                {
                    
                   
                    Console.Write("Gasto com saúde: ");
                    double GastoSaude = double.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaFisica(nome, rendaAnual, GastoSaude));
                }
                else 
                {
                    
                   
                    Console.Write("Número de funcionários: ");
                    int numFuncionarios = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(nome, rendaAnual, numFuncionarios));
                }



            }
            double soma = 0.0;
            Console.WriteLine();
            Console.WriteLine("Impostos Pagos ");
            foreach(Pessoa pessoa in pessoas)
            {
                double imposto = pessoa.CalcImposto();
                Console.WriteLine(pessoa.Nome + ": R$" + imposto.ToString());
                soma += imposto;
               
            }
            Console.WriteLine();
            Console.WriteLine("Total pagos: R$" + soma );
            Console.ReadKey();
        }
    }
}
