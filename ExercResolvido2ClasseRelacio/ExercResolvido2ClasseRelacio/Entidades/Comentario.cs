using System;
using System.Collections.Generic;
using System.Text;

namespace ExercResolvido2ClasseRelacio.Entidades
{
    class Comentario
    {
        public string Texto { get; set; }
        public Comentario()
        {

        }

        public Comentario(string text)
        {
            Text = text;
        }
    }
}
