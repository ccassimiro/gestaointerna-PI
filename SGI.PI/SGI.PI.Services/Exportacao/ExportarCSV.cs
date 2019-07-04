using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI.PI.Service.Membro;

namespace SGI.PI.Services.Exportacao
{
    public class ExportarCSV : IGeradorArquivos
    {
        public void ExportarDados(List<Membro> ListaMembros)
        {
            string nomeArquivo = @"c:\ListaDosMembros" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";

            StreamWriter writer = new StreamWriter(nomeArquivo);
            writer.WriteLine("ID;NOME;IDADE;SEXO;CPF;RG;ENDERECO;BAIRRO;CIDADE;CURSO;SEM. ATUAL;SEM. ENTRADA;SIGLA NUCLEO;CARGO;LIDERANCA;EMAIL");
            foreach (var membro in ListaMembros)
            {

                var pessoa = membro.Pessoa;
                var nucleo = membro.Nucleo;
                var cargo = membro.Cargo;

                writer.WriteLine(membro.Id + ";" + pessoa.Nome + ";" + pessoa.Idade + ";" + pessoa.Sexo + ";" + pessoa.CPF + ";" + pessoa.RG + ";" + pessoa.Endereco + ";" + (!String.IsNullOrEmpty(pessoa.Bairro) ? pessoa.Bairro : "") + ";" + pessoa.Cidade
                             + ";" + pessoa.Curso + ";" + pessoa.SemestreAtual + ";" + pessoa.SemestreEntradaNaEmpresa + ";" + nucleo.Sigla + ";" + cargo.Nome + ";" + cargo.Lideranca + ";" + pessoa.Email);
            }

            writer.Close();
        }

    }
}
