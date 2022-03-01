using System;

namespace ExerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Entre com o número de linhas e colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n];
            int cont=0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("Entre com o número da linha ["+i+"] e coluna ["+j+"]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                    if (mat[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            /*{
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);                       metodo alternativo
                    if (mat[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }*/
            /*Console.WriteLine("Diagonal Principal:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i,j]+" ");
                    }
                }
            }
            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i,i]+" ");                  metodo alternativo
            }*/
            /*Console.Write("Números negativos = "+cont);*/

            string[] d = Console.ReadLine().Split(' ');
            int l = int.Parse(d[0]);
            int c = int.Parse(d[1]);
            int[,] mat = new int[l,c];
            for (int i = 0; i < l; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }

            }
            int x = int.Parse(Console.ReadLine());
            for(int i=0; i < l; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.Write("Posição: "+i+", "+j);
                    }
                    if (j > 0)
                    {
                        Console.WriteLine("Left: " + mat[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Up: " + mat[i - 1, j]);
                    }
                    if (j < c - 1)
                    {
                        Console.WriteLine("Right: " + mat[i, j + 1]);
                    }
                    if (i < l - 1)
                    {
                        Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            }

        }
    }
}
