using System;
using System.Globalization;

namespace ExerEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //if (n < 0)
            //{
            //    Console.WriteLine("Negativo!");
            //}
            //else
            //{
            //    Console.WriteLine("Positivo!");
            //}

            //int n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("Par!");
            //}
            //else
            //{
            //    Console.WriteLine("Impar!");
            //}

            //string[] vet = Console.ReadLine().Split(' ');
            //int a = int.Parse(vet[0]);
            //int b = int.Parse(vet[1]);
            //if (a % b == 0 || b % a == 0)
            //{
            //    Console.WriteLine("São multiplos!");
            //}
            //else
            //{
            //    Console.WriteLine("Não são multiplos!");
            //}

            //string[] vet = Console.ReadLine().Split(' ');
            //float hi = float.Parse(vet[0]);
            //float hf = float.Parse(vet[1]);
            //float d;
            //if (hi > hf)
            //{
            //    d = 24 - hi + hf;
            //}else if (hi < hf)
            //{
            //    d = hf - hi;
            //}
            //else
            //{
            //    d = 24;
            //}
            //Console.WriteLine("O jogo durou: " + d);

            //string[] vet = Console.ReadLine().Split(' ');
            //int cod = int.Parse(vet[0]);
            //int q = int.Parse(vet[1]);
            //double t;
            //if (cod == 1)
            //{
            //    t = 4.00 * q;
            //    Console.WriteLine("Total a pagar:" + t.ToString("F2", CultureInfo.InvariantCulture));
            //}else if (cod == 2)
            //{
            //    t = 4.50 * q;
            //    Console.WriteLine("Total a pagar:" + t.ToString("F2", CultureInfo.InvariantCulture));
            //}else if (cod == 3)
            //{
            //    t = 5.00 * q;
            //    Console.WriteLine("Total a pagar:" + t.ToString("F2", CultureInfo.InvariantCulture));
            //}else if (cod == 4)
            //{
            //    t = 2.00 * q;
            //    Console.WriteLine("Total a pagar:" + t.ToString("F2", CultureInfo.InvariantCulture));
            //}
            //else
            //{
            //    t = 1.50 * q;
            //    Console.WriteLine("Total a pagar:" + t.ToString("F2", CultureInfo.InvariantCulture));
            //}

            //float v = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //if (v < 0.0 || v > 100.0)
            //{
            //    Console.WriteLine("fora de intervalo");
            //}
            //else if (v <= 25.0)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (v <= 50.0)
            //{
            //    Console.WriteLine("Intervalo [25,50]");
            //}
            //else if (v <= 75.0)
            //{
            //    Console.WriteLine("Intervalo [50,75]");
            //}
            //else
            //{
            //    Console.WriteLine("Intervalo [75,100]");
            //}

            //string[] vet = Console.ReadLine().Split(' ');
            //float x = float.Parse(vet[0], CultureInfo.InvariantCulture);
            //float y = float.Parse(vet[1], CultureInfo.InvariantCulture);
            //if (x == 0 && y == 0.0)
            //{
            //    Console.WriteLine("Origem");
            //}else if (x == 0.0)
            //{
            //    Console.WriteLine("Eixo X");
            //}else if (y == 0.0)
            //{
            //    Console.WriteLine("Eixo Y");
            //}else if (x < 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q3");
            //}else if (x > 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q4");
            //}else if (x < 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q2");
            //}else
            //{
            //    Console.WriteLine("Q1");
            //}

            double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double i=0.0;
            if (v < 2000.01)
            {
                Console.WriteLine("Isento");
            }else if (v < 3000.01)
            {
                i = (v - 2000.00) * 0.08;
            }else if (v < 4500.01)
            {
                i = (v - 3000.00) * 0.18 + 1000 * 0.08;
            }
            else
            {
                i = (v - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            Console.WriteLine("valor de imposto: " + i.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
