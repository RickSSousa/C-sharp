using System;

namespace ExercVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospedes[] vet = new Hospedes[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #"+(i+1)+":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int q = int.Parse(Console.ReadLine());
                vet[q] = new Hospedes (nome,email);

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }

        }
    }
}
