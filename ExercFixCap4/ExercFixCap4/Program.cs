using System;
using System.Globalization;

namespace ExercFixCap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Emtre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? ");
            char r = char.Parse(Console.ReadLine());
            if (r == 's')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, valor);
            }
            else
            {
                conta = new Conta(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com o valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);
        }
    }
}
