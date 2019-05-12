using SGI.PI.Service.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Service.Membro
{
    public class MembroHistorico
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public virtual Membro Membro { get; set; }
        [Required]
        public virtual Nucleo Nucleo { get; set; }
        [Required]
        public virtual Cargo Cargo { get; set; }
        [Required]
        public virtual Pessoa Pessoa { get; set; }
        //ALTERAR PARA USUÁRIO O CRIADO POR E ADICIONAR REQUIRED
        public virtual Pessoa CriadoPor { get; set; }
        [Required]
        public DateTime CriadoEm { get; set; }

    }
}
