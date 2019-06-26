using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Xml.Schema;

namespace SGI.PI.Web.Models
{
    public class ImportacaoViewModel
    {
        [Required, Microsoft.Web.Mvc.FileExtensions(Extensions = "csv",
            ErrorMessage = "Por favor, insira um arquivo no formato CSV.")]
        public HttpPostedFileBase Arquivo { get; set; }

        
    }
}