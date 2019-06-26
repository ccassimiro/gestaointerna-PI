using SGI.PI.Service.Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Data.Repository
{
    public interface IGenericRepository<TEntity>
        where TEntity : class
        //T e uma variável genérica, então quando chamarmos isso em cada uma das classes que temos, T será a classe em questão
    {
        void Adicionar(TEntity objeto);
        void Excluir(int id);
        void Atualizar(TEntity objeto);
        TEntity EncontrarPorID(int id);
        IList<TEntity> EncontrarTodos();
        Cargo EncontrarPorSigla(string sigla);
    }
}
