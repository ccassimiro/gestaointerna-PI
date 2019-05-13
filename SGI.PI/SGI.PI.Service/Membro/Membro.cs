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


        public Membro(string nome, int idade, string sexo, string cpf, string rg, string endereco, string bairro, string cidade, string curso, int semestreAtual, int semestreEntrada, Nucleo siglaNucleo, Cargo cargo)
        {

            this.Cargo = cargo;
            this.Nucleo = siglaNucleo;
            //chamando o construtor de pessoa.
            this.Pessoa = new Pessoa(nome, idade, sexo, cpf, rg, endereco, bairro, cidade, curso, semestreAtual, semestreEntrada);
        }

        public void CriarUsuario()
        {
            if(this.Cargo.Lideranca == true)
            {
                //Logica para criar um usuário no sistema.
                //VER C LAPA.
            }
        }

    }
}
