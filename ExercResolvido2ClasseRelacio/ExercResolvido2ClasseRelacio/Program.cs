using System;
using ExercResolvido2ClasseRelacio.Entidades;

namespace ExercResolvido2ClasseRelacio
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Tenha uma boa viagem");
            Comentario c2 = new Comentario("Uau que Legal!");

            Post p1 = new Post(DateTime.Parse("21/06/2012 13:05:44"),
                "Viajando para Portugal",
                "Passando as férias em um país diferente",
                345);
            p1.AddComentario(c1);
            p1.AddComentario(c2);

            Comentario c3 = new Comentario("Que legal!");
            Comentario c4 = new Comentario("Manda salve");

            Post p2 = new Post(DateTime.Parse("07/03/2001 15:43:50"),
                "Visitando os tios",
                "Vim dar um abraço nos meus parentes mais distantes",
                345);
            p2.AddComentario(c3);
            p2.AddComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
