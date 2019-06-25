using SGI.PI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGI.PI.Web.Controllers
{
    public class ImportacaoController : Controller
    {
        // GET: Importacao
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Importar(ImportacaoViewModel model)
        //{
        //    return View("ListagemMembros");
        //}
    }
}