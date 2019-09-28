using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sys_bodega.DAL;

namespace sys_bodega.Controllers
{
    public class ProductosController : Controller
    {
        ProductoDal productoDal = new ProductoDal();
        public ActionResult findAll()
        {
            var lstProductos = productoDal.FindAllProducto();
            return View(lstProductos);
        }
    }
}