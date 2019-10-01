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
        public int cantEstablecida {get;set;}
        public int cantExistencia { get; set; }
        public int cantMinima { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaVencimientoProducto { get; set; }
        public int idEstado { get; set; }      
    }
}