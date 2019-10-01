using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sys_bodega.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public char token { get; set; }
        public int idEstado { get; set; }

        public virtual Estado estado { get; set; }
    }
}