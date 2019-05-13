using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Service.Empresa
{
    public class Cargo
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public bool Lideranca { get; set; }

        public static explicit operator Cargo(string v)
        {
            throw new NotImplementedException();
        }
    }
}
