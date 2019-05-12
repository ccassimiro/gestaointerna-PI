using SGI.PI.Service.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Service.Membro
{
    public class Membro
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public virtual Nucleo Nucleo { get; set; }

        [Required]
        public virtual Cargo Cargo { get; set; }

        [Required]
        public virtual Pessoa Pessoa { get; set; }


    }
}
