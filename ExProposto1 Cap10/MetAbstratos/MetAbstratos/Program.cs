using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetAbstratos.Entities;
using System.Globalization;

namespace MetAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();
            Console.Write("Entre com o número de contribuintes: ");
            int nc = int.Parse(Console.ReadLine());
            for(int i = 1; i <= nc; i++)
            {
                Console.WriteLine($"Entre com os dados do contribuinte #{i}");
                Console.Write("Pessoa Física ou Jurídica (f/j)? ");
                char r = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double ra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(r == 'f')
                {
                    Console.Write("Entre com os gastos em saúde: ");
                    double gs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, ra, gs));
                }
                else
                {
                    Console.Write("Entre com o número de funcionários: ");
                    int nf = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, ra, nf));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAX PAID:");
            foreach (Contribuinte item in list)
            {
                Console.WriteLine(item.Nome + ": $ " + item.Impostos().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            double sum = 0.0;
            foreach (Contribuinte item in list)
            {
                sum += item.Impostos();
            }
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
