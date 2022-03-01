using System;
using System.Collections.Generic;
using System.Text;

namespace ExercResolvido2ClasseRelacio.Entidades
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoveComentario(Comentario comenario)
        {
            Comentarios.Remove(comenario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários: ");
            foreach(Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    }
}
