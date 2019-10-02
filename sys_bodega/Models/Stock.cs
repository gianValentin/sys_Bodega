using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sys_bodega.Models
{
    public class Stock
    {
        public string codigoBarra { get; set; }
        public int idProducto { get;set; }
        public int idEstado { get; set; }
    }
}