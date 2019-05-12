using SGI.PI.Service.Membro;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Data.Mapping
{
    public class PessoaMapping : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMapping()
        {
            this.ToTable("Pessoa");
            this.HasKey(t => t.Id);
            this.Property(t => t.Bairro);
            this.Property(t => t.Cidade).IsRequired();
            this.Property(t => t.Curso).IsRequired();
            this.Property(t => t.CPF).IsRequired();
            this.Property(t => t.Endereco).IsRequired();
            this.Property(t => t.Idade).IsRequired();
            this.Property(t => t.Nome).IsRequired();
            this.Property(t => t.RG).IsRequired();
            this.Property(t => t.SemestreAtual).IsRequired();
            this.Property(t => t.SemestreEntradaNaEmpresa).IsRequired();
            this.Property(t => t.Sexo).IsRequired();
        }
    }
}
