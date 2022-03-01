using System;
using System.Globalization;

namespace ExerEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1, n2, soma;
            //n1 = int.Parse(Console.ReadLine());
            //n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Soma: " + (soma = n1+n2));

            //double pi = 3.14159, area, r;
            //r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //area = pi * Math.Pow(r,2);
            //Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //int D = int.Parse(Console.ReadLine());
            //int diferenca = A * B - C * D;
            //Console.WriteLine("DIFERENÇA = " + diferenca);

            //int n = int.Parse(Console.ReadLine());
            //float h = float.Parse(Console.ReadLine());
            //double s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double salario = s * h;
            //Console.WriteLine("Número: " + n);
            //Console.WriteLine("Salário: R$" + salario.ToString("F2", CultureInfo.InvariantCulture));

            //string[] v1 = Console.ReadLine().Split(' ');
            //string[] v2 = Console.ReadLine().Split(' ');
            //int np1 = int.Parse(v1[1]);
            //float vp1 = float.Parse(v1[2], CultureInfo.InvariantCulture);
            //int np2 = int.Parse(v2[1]);
            //float vp2 = float.Parse(v2[2], CultureInfo.InvariantCulture);
            //float total = vp1 * np1 + vp2 * np2;
            //Console.WriteLine("Valor a pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));

            string[] vet = Console.ReadLine().Split(' ');
            float a = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float b = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float c = float.Parse(vet[2], CultureInfo.InvariantCulture);
            double triangulo = a*c/2;
            double circulo = 3.14159 * Math.Pow(c, 2.0);
            double trapezio = (a + b) / 2.0 * c;
            double quadrado = b * b;
            double retangulo = a * b;
            Console.WriteLine("TRIANGLO = " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO = " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO = " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO = " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
