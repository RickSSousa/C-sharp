using System;
using System.Collections.Generic;
using System.Text;
using ExercTiposEnum.Entidades.Enuns; // precisa colocar esse namespce pra essa classe enxergar a Enuns

namespace ExercTiposEnum.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Momento + ", " + Status;
        }
    }
}
