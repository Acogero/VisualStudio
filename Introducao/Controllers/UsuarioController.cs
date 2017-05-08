using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            var usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            //Se os dados do usuário for válido
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
    }
}