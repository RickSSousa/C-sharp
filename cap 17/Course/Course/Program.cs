using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;
using System.IO;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho do arquivo: ");
            string paph = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using(StreamReader sr = File.OpenText(paph))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"E-mail dos funcionarios com salário acima de {sal.ToString("F2", CultureInfo.InvariantCulture)}:");
            var empemail = list.Where(e => e.Salary > sal).OrderBy(e => e.Email).Select(e => e.Email);
            foreach (string email in empemail)
            {
                Console.WriteLine(email);
            }

            var sum = list.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma do salário dos funcionários que começam com 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
