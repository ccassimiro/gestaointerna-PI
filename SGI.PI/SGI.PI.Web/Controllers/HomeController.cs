﻿using SGI.PI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGI.PI.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("ImportacaoMembros");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Importar(ImportacaoViewModel model)
        {
            return View("Listagem");
        }
    }
}