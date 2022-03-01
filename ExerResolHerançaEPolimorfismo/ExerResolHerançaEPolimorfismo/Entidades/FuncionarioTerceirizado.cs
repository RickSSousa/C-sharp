using System;
using System.Collections.Generic;
using System.Text;

namespace ExerResolHerançaEPolimorfismo.Entidades
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DispesaAdicional { get; set; }

        public FuncionarioTerceirizado()
        {
        }

        public FuncionarioTerceirizado(string nome, int horas, double valorPorHora, double dispesaAdicional)
            :base(nome,horas,valorPorHora)
        {
            DispesaAdicional = dispesaAdicional;
        }
        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DispesaAdicional;
        }
    }
}
