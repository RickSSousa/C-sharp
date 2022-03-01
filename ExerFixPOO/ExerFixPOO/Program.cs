using System;
using System.Globalization;

namespace ExerFixPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retangulo ret = new Retangulo();
            //Console.WriteLine("Entre a largura e altura do retângulo:");
            //ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Área = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            //Funcionario f = new Funcionario();
            //Console.Write("Nome: ");
            //f.Nome = Console.ReadLine();
            //Console.Write("Salário bruto: ");
            //f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Imposto: ");
            //f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Funcionário: " + f);
            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //float p = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //f.AumentarSalario(p);
            //Console.WriteLine("Dados atualizados: " + f);

            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota final: " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (a.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
