using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetAbstratos.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Impostos()
        {
            double imp = 0.0;
            if (RendaAnual < 20000.0)
            {
                imp = RendaAnual * 0.15;
            }
            else
            {
                imp = RendaAnual * 0.25;
            }
            if(GastoSaude > 0.0)
            {
                imp = imp - (GastoSaude / 2);
            }
            return imp;
        }
    }
}
