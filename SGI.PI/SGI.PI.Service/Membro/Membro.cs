using SGI.PI.Service.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.PI.Data.Repository;


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

        //retorna uma lista de usuários a serem criados.
        public List<Membro> CriarUsuario()
        {
            var ListaMembros = new List<Membro>();
            if(this.Cargo.Lideranca == true)
            {
                ListaMembros.Add(this);
            }

            return ListaMembros;
        }

        //Listagem de membros e Edição de membro
        public List<Membro> ListarTodosMembros()
        {
            GenericRepository<Membro> repository = new GenericRepository<Membro>();
            var ListaMembros = repository.EncontrarTodos().ToList();

            return ListaMembros;
        }

        public Membro ProcurarMembroPorId(int id)
        {
            GenericRepository<Membro> repository = new GenericRepository<Membro>();
            Membro membro = repository.EncontrarPorID(id);

            return membro;

        }

        public void EditarMembro(Membro membro)
        {
            GenericRepository<Membro> repository = new GenericRepository<Membro>();
            repository.Atualizar(membro);
        }

        public void RemoverMembro(int id)
        {
            GenericRepository<Membro> repository = new GenericRepository<Membro>();
            repository.Excluir(id);
        }
    }
}
