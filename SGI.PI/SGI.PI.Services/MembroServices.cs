using SGI.PI.Data.Repository;
using SGI.PI.Service.Empresa;
using SGI.PI.Service.Membro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Services
{
    class MembroServices
    {
        public GenericRepository<Membro> MembroRepository { get; set; }
        public List<Membro> ListaMembrosParaInserir { get; set; }

        //Criar método para importação de membro.
        public void ImportarMembrosCSV(string caminho)
        {
            StreamReader rd = new StreamReader(caminho);
            string linha = null;
            string[] linhaSeparada = null;

            try
            {
                while ((linha = rd.ReadLine()) != null)
                {
                    linhaSeparada = linha.Split(';');

                    var Nome = linhaSeparada[0];
                    var Idade = Convert.ToInt32(linhaSeparada[1]);
                    var Sexo = linhaSeparada[2];
                    var CPF = linhaSeparada[3];
                    var RG = linhaSeparada[4];
                    var Endereco = linhaSeparada[5];
                    var Bairro = linhaSeparada[6];
                    var Cidade = linhaSeparada[7];
                    var Curso = linhaSeparada[8];
                    var SemestreAtual = Convert.ToInt32(linhaSeparada[9]);
                    var SemestreEntrada = Convert.ToInt32(linhaSeparada[10]);
                    var SiglaNueclo = (Nucleo)linhaSeparada[11];
                    var Cargo = (Cargo)linhaSeparada[12];
                    var Lideranca = linhaSeparada[13];

                    Membro m = new Membro(Nome, Idade, Sexo, CPF, RG, Endereco, Bairro, Cidade, Curso, SemestreAtual, SemestreEntrada, SiglaNueclo, Cargo);
                    //Adiciona os membros em uma lista, para ao final do processo ser conferido em tela. Caso seja aceito, chamará o método abaixo que realizará
                    //a inserção de maneira correta (atendendo o que foi proposto para Ingrid). Criar um método para validar a inserção
                    ListaMembrosParaInserir.Add(m);

                    
                }
                rd.Close();
            }
            catch (Exception e)
            {
                //Remover exception quando tiver OK.
                throw new Exception("Não foi possível acessar o arquivo. Erro: "+ e);
            }

        }

        public List<Membro> InserirNovosMembros(List<Membro> Membros)
        {
            var MembroComUsuario = new List<Membro>();
            
            foreach(Membro m in Membros)
            {
                MembroRepository.Adicionar(m);
                if (m.Cargo.Lideranca == true)
                    MembroComUsuario.Add(m);
            }
            //Colocar ao final uma mensagem de "Foram inseridos I novos membros ao sistema. Atendendo Heurísticas de Nilsen para Ingrid.
            return MembroComUsuario;
        }

        public List<Membro> ListarMembros()
        {
            var TodosMembros = MembroRepository.EncontrarTodos().ToList();

            return TodosMembros;
        }

        public Membro ProcurarMembroPorId(int id)
        {
            Membro membro = MembroRepository.EncontrarPorID(id);

            return membro;

        }

        public void EditarMembro(Membro membro)
        {
            
            MembroRepository.Atualizar(membro);
        }

        public void RemoverMembro(int id)
        {
            MembroRepository.Excluir(id);
        }

    }
}
