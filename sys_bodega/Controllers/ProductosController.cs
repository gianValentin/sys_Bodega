using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sys_bodega.DAL;
using sys_bodega.Models;

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
        
        public ActionResult addProductoStock()
        {
         
            return View();
        }

        [HttpPost]
        public ActionResult addProductoStock(Producto oProducto,Array codigosBarra)
        {
            var result = "";
            if (productoDal.addProducto(oProducto).Equals("ok"))
            {
                foreach (var cod in codigosBarra)
                {
                    //pendiente
                }
            }
            else
                result = "error al guardar datos de Producto!";

            

            return Content(result);
        }
    }
}