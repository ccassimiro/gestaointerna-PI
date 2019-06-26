using SGI.PI.Service.Empresa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Data.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        public SGIContext contexto;

        public GenericRepository()
        {
            this.contexto = new SGIContext();
        }
        public void Adicionar(TEntity objeto)
        {
            contexto.Set<TEntity>().Add(objeto);
            contexto.SaveChanges();
        }
        // O atualizar ainda não tão prontos pois falta fazer a parte de pegar o id
        public void Atualizar(int id)
        {
            var entity = contexto.Set<TEntity>().Find(id);
            contexto.Entry(entity).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Atualizar(TEntity objeto)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            contexto.Set<TEntity>().Remove(contexto.Set<TEntity>().Find(id));
            contexto.SaveChanges();
        }

        public TEntity EncontrarPorID(int id)
        {
            return contexto.Set<TEntity>().Find(id);

        }

        public Cargo EncontrarPorSigla(string sigla)
        {
            return contexto.Set<Cargo>().Where(a => a.Nome == sigla).FirstOrDefault();
        }

        public IList<TEntity> EncontrarTodos()
        {
            return contexto.Set<TEntity>().ToList();
        }

        
    }

}
