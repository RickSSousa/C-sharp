using System;
using Cap9ExResolvido.Entidades.Enums;
using Cap9ExResolvido.Entidades;
using System.Globalization;

namespace Cap9ExResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do Departamento: ");
            string dptNome = Console.ReadLine();
            Console.WriteLine("Entre com os dados do trabalhador:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Level");
            Level level = Enum.Parse<Level>(Console.ReadLine());
            // isso converte um string digitado pelo usuário para um Level da classe enumerada
            Console.Write("Salário base: ");
            double SalarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dpt = new Departamento(dptNome);
            //isso instancia o departamento e relacionando com meu trabalhador

            Trabalhador trabalhador = new Trabalhador(nome, level, SalarioBase, dpt);
            //isso instancia meu trabalhador com seus dados

            Console.Write("Quantos contratos para esse trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do #{i} contrato:");
                Console.Write("Data (dd/mm/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double ValorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());
                HoraContrato contrato = new HoraContrato(data, ValorPorHora, horas);
                trabalhador.AddContrato(contrato);
                //adiciona esse contrato nos contratos do Trabalhador

            }
            Console.WriteLine();
            Console.Write("Entre com o mês e ano (mm/YYYY): ");
            string MesAno = Console.ReadLine();
            int Mes = int.Parse(MesAno.Substring(0, 2)); //a função Substring me retornará, a partir da posição 0, 2 posições
            int Ano = int.Parse(MesAno.Substring(3));
            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Name); // trabalhador acessará o departamento que acessará o nome
            Console.WriteLine("Ganho " + MesAno + ": " + trabalhador.Ganho(Ano, Mes).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
