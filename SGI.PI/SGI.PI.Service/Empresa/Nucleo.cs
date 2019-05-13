using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Service.Empresa
{
    public class Nucleo
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sigla { get; set; }
        [Required]
        public virtual Departamento Departamento { get; set; }

        public static explicit operator Nucleo(string v)
        {
            throw new NotImplementedException();
        }
    }
}
