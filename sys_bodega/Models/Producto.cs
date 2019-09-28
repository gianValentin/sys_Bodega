using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sys_bodega.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public int idStock { get; set; }
    }
}