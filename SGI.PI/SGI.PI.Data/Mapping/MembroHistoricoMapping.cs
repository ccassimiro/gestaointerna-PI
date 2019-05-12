using SGI.PI.Service.Membro;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Data.Mapping
{
    public class MembroHistoricoMapping : EntityTypeConfiguration<MembroHistorico>
    {
        public MembroHistoricoMapping()
        {
            this.ToTable("MembroHistorico");
            this.HasKey(t => t.Id);
            this.Property(t => t.CriadoEm).IsRequired();
            this.HasRequired(t => t.Pessoa).WithRequiredDependent();
            this.HasRequired(t => t.Nucleo).WithRequiredDependent();
            this.HasRequired(t => t.Cargo).WithRequiredDependent();
            this.HasRequired(t => t.CriadoPor).WithRequiredDependent();
        }
    }
}
