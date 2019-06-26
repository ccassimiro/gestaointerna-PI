using SGI.PI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SGI.PI.Services;
using SGI.PI.Service.Membro;
using System.IO;
using System.Data;
using CsvHelper;

namespace SGI.PI.Web.Controllers
{
    public class ImportacaoController : Controller
    {
        // GET: Importacao
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Importar(ImportacaoViewModel model)
        {
            var membros = ReceberMembrosCSV(model.Arquivo);
            return View("Listagem");
        }

        public List<Membro> Upload(HttpPostedFileBase upload)
        {
            List<Membro> membros = new List<Membro>();
            string linha = null;
            if (ModelState.IsValid)
            {

                //if (upload != null && upload.ContentLength > 0)
                //{

                //    if (upload.FileName.EndsWith(".csv"))
                //    {
                //        Stream stream = upload.InputStream;
                //        DataTable csvTable = new DataTable();
                //        using (CsvReader csvReader =
                //            new CsvReader(new StreamReader(stream)))
                //        {
                //            var csv = csvReader.ToString();
                //            //csvTable.Load(csvReader);
                //        }
                //    }
                //}

                using (var reader = new StreamReader("/teste/tt.csv"))
                using (var csv = new CsvReader(reader))
                {
                    var records = csv.ToString();
                }

            }

            return membros;
        }

        public List<Membro> ReceberMembrosCSV(HttpPostedFileBase Arquivo)
        {
            MembroServices membro = new MembroServices();
            membro.ImportarMembrosCSV(Arquivo.ToString());
            //var membros = Upload(Arquivo);

            return membro.ListaMembrosParaInserir;
        }
    }
}