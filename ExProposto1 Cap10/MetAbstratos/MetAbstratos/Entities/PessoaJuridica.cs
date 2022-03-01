using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetAbstratos.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumFunc { get; set; }
        public PessoaJuridica(string nome, double rendaAnual, int numFunc) :base(nome, rendaAnual)
        {
            NumFunc = numFunc;
        }
        public override double Impostos()
        {
            double imp = 0.0;
            if (NumFunc <= 10)
            {
                imp = RendaAnual * 0.16;
            }
            else
            {
                imp = RendaAnual * 0.14;
            }
            return imp;
        }
    }
}
