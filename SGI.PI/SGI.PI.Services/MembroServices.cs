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
    public class MembroServices
    {
        public GenericRepository<Membro> MembroRepository { get; set; }
        public GenericRepository<Nucleo> NucleoRepository { get; set; }
        public GenericRepository<Cargo> CargoRepository { get; set; }
        public List<Membro> ListaMembrosParaInserir { get; set; }

        public MembroServices()
        {
            ListaMembrosParaInserir = null;
        }

        //Criar método para importação de membro.
        public void ImportarMembrosCSV(string caminho)
        {
            StreamReader rd = new StreamReader("/teste/testeCad.csv");
            string linha = null;
            string[] linhaSeparada = null;

            try
            {
                while ((linha = rd.ReadLine()) != null)
                {
                    linhaSeparada = linha.Split(';');

                    if (linhaSeparada[0].Equals("NOME"))
                        continue;

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
                    var SiglaNucleo = linhaSeparada[11];
                    var Cargo = linhaSeparada[12];
                    var Lideranca = linhaSeparada[13];
                    var Email = linhaSeparada[14];

                    Cargo CargoIns = new Service.Empresa.Cargo();
                    CargoIns.Id = 1;
                    CargoIns.Nome = "Gerente";
                    CargoIns.Lideranca = true;
                    //var CargoIns = CargoRepository.EncontrarPorSigla(Cargo);
                    Nucleo NucleoIns = new Nucleo();
                    NucleoIns.Id = 1;
                    NucleoIns.Nome = "Nucleo de Projetos de Computação";
                    NucleoIns.Sigla = "NPCP";
                    Departamento dep = new Departamento();
                    dep.Id = 3;
                    dep.Nome = "Departamento de Projetos";
                    dep.Sigla = "DPJ";
                    NucleoIns.Departamento = dep;
                    //var NucleoIns = NucleoRepository.EncontrarPorSigla(SiglaNucleo);


                    Membro m = new Membro(Nome, Idade, Sexo, CPF, RG, Endereco, Bairro, Cidade, Curso, SemestreAtual, SemestreEntrada, NucleoIns, CargoIns, Email);
                    //Adiciona os membros em uma lista, para ao final do processo ser conferido em tela. Caso seja aceito, chamará o método abaixo que realizará
                    //a inserção de maneira correta (atendendo o que foi proposto para Ingrid). Criar um método para validar a inserção
                    //ListaMembrosParaInserir.Add(m);
                    MembroRepository.Adicionar(m);

                    
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
