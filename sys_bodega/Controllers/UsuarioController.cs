using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sys_bodega.Models;
using sys_bodega.DAL;

namespace sys_bodega.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        UsuarioDal usuarioDal = new UsuarioDal();
        public ActionResult FindAll()
        {
            var lstUsuario = usuarioDal.FindAllUsuario();


            return View(lstUsuario);
        }
    }
}