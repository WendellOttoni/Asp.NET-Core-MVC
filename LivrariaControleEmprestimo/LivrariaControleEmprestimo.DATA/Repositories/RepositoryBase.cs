using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModels<T>, IDisposable where T : class
    {
        protected BibliotecaContext _contexto;
        public bool _SaveChanges = true;

        public RepositoryBase(bool SaveChages = true)
        {
            _SaveChanges = SaveChages;
            _contexto = new BibliotecaContext();
        }

        public T Add(T objeto)
        {
            _contexto.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }

            return objeto;
        }

        public void Delete(T objeto)
        {
            _contexto.Set<T>().Remove(objeto);
            
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
        }

        public void Delete(params object[] variavel)
        {
            var obj = GetPK(variavel);
            Delete(obj);
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public List<T> GetAll()
        {
            return _contexto.Set<T>().ToList();
        }

        public T GetPK(params object[] variavel)
        {
            return _contexto.Set<T>().Find(variavel);
        }

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }

        public T Update(T objeto)
        {
            _contexto.Entry(objeto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            if(_SaveChanges)
            {
                _contexto.SaveChanges();
            }

            return objeto; 
        }
    }
}
