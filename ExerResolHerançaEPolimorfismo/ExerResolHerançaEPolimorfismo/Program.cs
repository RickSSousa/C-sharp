using System;
using System.Collections.Generic;
using ExerResolHerançaEPolimorfismo.Entidades;
using System.Globalization;

namespace ExerResolHerançaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> func = new List<Funcionario>();
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do #{i} funcionário:");
                Console.Write("É terceirizado? (s/n) ");
                char r = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int h = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double vh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (r == 's')
                {
                    Console.Write("Despesa adicional: ");
                    double da = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    func.Add(new FuncionarioTerceirizado(nome, h, vh, da));
                }
                else
                {
                    func.Add(new Funcionario(nome, h, vh));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pagamentos:");
            foreach (Funcionario f in func)
            {
                Console.WriteLine(f.Nome + " - $" + f.Pagamento().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
