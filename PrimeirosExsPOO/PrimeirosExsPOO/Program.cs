using System;
using System.Globalization;

namespace PrimeirosExsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p1, p2;
            //p1 = new Pessoa();
            //p2 = new Pessoa();
            //Console.WriteLine("Entre com os dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com os dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());
            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            //}

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double m = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Média: " + m.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
