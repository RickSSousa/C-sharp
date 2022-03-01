using System;
using ExTratamentoExcecoes.Entities;
using ExTratamentoExcecoes.Entities.Exceptions;
using System.Globalization;

namespace ExTratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string h = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double ib = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double wl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(n, h, ib, wl);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(w);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExecpions e)
            {
                Console.WriteLine("Erro ao sacar: " + e.Message);
            }
        }
    }
}
