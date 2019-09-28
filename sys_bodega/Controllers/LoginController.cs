using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sys_bodega.DAL;
using sys_bodega.Models;

namespace sys_bodega.Controllers
{
    public class LoginController : Controller
    {
        UsuarioDal usuarioDal = new UsuarioDal();
        // GET: Login
        public ActionResult Index()
        {                        
            return View();
        }

        [HttpPost]
        public ActionResult Verifica(string txtUsuario,string txtcontraseña)
        {            
            var val = (usuarioDal.VerificaUsuarioLogin(txtUsuario, txtcontraseña)) ? "1" : "no existe";
            return Content(val);
            
        }
        
        public ActionResult LogOff()
        {
            Session["usuario"] = null;

            return RedirectToAction("index", "Login");
        }
    }
}