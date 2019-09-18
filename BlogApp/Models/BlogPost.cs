using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class BlogPost
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public Comentario Comentario { get; set; }
        public List<Comentario> Comentarios { get; }
        public string Categoria { get; set; }
    }
}
