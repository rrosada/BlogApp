using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class Comentario
    {
        public int UsuarioId { get; set; }
        public int PostId { get; set; }
        public string Descricao { get; set; }
    }
}
