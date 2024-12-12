using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContribuinte.Entitites
{
    class PessoaJuridica : Pessoa
    {

        public int NumFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string name, double rendaAnual, int numFuncionarios) : base(name, rendaAnual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double CalcImposto()
        {
            if (NumFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else return RendaAnual * 0.16;
        }
    }
}
