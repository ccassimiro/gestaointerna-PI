using SGI.PI.Service.Membro;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Data.Mapping
{
    public class MembroMapping : EntityTypeConfiguration<Membro>
    {
        public MembroMapping()
        {
            this.ToTable("Membro");
            this.HasKey(t => t.Id);
            this.HasRequired(t => t.Pessoa).WithRequiredDependent();
            this.HasRequired(t => t.Nucleo).WithRequiredDependent();
            this.HasRequired(t => t.Cargo).WithRequiredDependent();
        }


    }
}
