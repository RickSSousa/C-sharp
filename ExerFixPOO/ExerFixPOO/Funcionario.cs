using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerFixPOO
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto, Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public double AumentarSalario(double porcentagem)
        {
            return SalarioBruto += SalarioBruto * porcentagem / 100.00;
        }
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
