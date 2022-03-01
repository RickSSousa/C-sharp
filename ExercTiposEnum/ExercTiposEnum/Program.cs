using System;
using ExercTiposEnum.Entidades;
using ExercTiposEnum.Entidades.Enuns;

namespace ExercTiposEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido { Id = 1080, Momento = DateTime.Now, Status = StatusPedido.PagamentoPendente };
            Console.WriteLine(pedido);

            string txt = StatusPedido.PagamentoPendente.ToString(); //converter enumerado para string

            StatusPedido os = Enum.Parse<StatusPedido>("Entregue"); // converte string pro tipo enumerado
            //se escrever o string diferente do que está definido na classe statuspedido, ex: "Entrege", vai dar erro

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}
