using SGI.PI.Service.Empresa;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Data.Mapping
{
    public class CargoMapping : EntityTypeConfiguration<Cargo>
    {
        public CargoMapping()
        {
            this.ToTable("Cargo");
            this.HasKey(t => t.Id);
            this.Property(t => t.Nome).IsRequired();
            this.Property(t => t.Lideranca).IsRequired();
        }
    }
}
