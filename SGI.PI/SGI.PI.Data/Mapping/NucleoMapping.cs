using SGI.PI.Service.Empresa;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Data.Mapping
{
    public class NucleoMapping : EntityTypeConfiguration<Nucleo>
    {
        public NucleoMapping()
        {
            this.ToTable("Nucleo");
            this.HasKey(t => t.Id);
            this.Property(t => t.Nome).IsRequired();
            this.Property(t => t.Sigla).IsRequired();
            this.HasRequired(t => t.Departamento).WithRequiredDependent();
            
        }
    }
}
