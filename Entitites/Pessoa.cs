using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContribuinte.Entitites
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa()
        {

        }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcImposto();
    }
}
