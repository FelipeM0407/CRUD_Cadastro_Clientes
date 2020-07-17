using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Cadastro_Clientes.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult About()
        {
            ViewBag.Message = "CRUD Simples que adiciona, edita e exclue dados de clientes";

            return View();
        }

    }
}