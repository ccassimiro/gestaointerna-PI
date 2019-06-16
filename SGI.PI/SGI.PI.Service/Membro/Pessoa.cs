using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Service.Membro
{
    public class Pessoa
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string RG { get; set; }
        [Required]
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Curso { get; set; }
        [Required]
        public int SemestreAtual { get; set; }
        [Required]
        public int SemestreEntradaNaEmpresa { get; set; }
        [Required]
        public string Email { get; set; }

        public Pessoa(string nome, int idade, string sexo, string cpf, string rg, string endereco, string bairro, string cidade, string curso, int semestreAtual, int semestreEntrada)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.CPF = cpf;
            this.RG = rg;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Curso = curso;
            this.SemestreAtual = semestreAtual;
            this.SemestreEntradaNaEmpresa = semestreEntrada;
            this.Email = Email;
        }
    }
}
