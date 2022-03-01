using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Quantos funcionários deseja registrar? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #"+i+": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.WriteLine("Entre com o ID do funcionário para poder acrescentar o salário: ");
            int idp = int.Parse(Console.ReadLine());

            Employee func = list.Find(x => x.Id == idp);
            if (func != null)
            {
                Console.Write("Entre com a porcentagem:");
                double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.IncreaseSalary(p);
            }
            else
            {
                Console.WriteLine("Esse ID não existe");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos funcionários:");
            foreach (Employee item in list)        // o Employee é o tipo da minha lista, por isso vou procurar um item desse tipo
            {
                Console.WriteLine(item);
            }
        }
    }
}
