using System;
using System.Collections.Generic;
using System.Text;

namespace Cap9ExResolvido.Entidades
{
    class HoraContrato
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Hora { get; set; }
        public HoraContrato()
        {

        }

        public HoraContrato(DateTime data, double valorPorHora, int hora)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Hora = hora;
        }

        public double ValorTotal()
        {
            return ValorPorHora * Hora;
        }
    }
}
