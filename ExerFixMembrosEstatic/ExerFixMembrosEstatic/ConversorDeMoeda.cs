using System;
using System.Collections.Generic;
using System.Text;

namespace ExerFixMembrosEstatic
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double CalcularDolar(double q, double c)
        {
            double total = q * c;
            return total + total * Iof / 100.0;
        }
    }
}
