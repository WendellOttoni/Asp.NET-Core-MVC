using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Interfaces
{
    public interface IRepositoryModels<T> where T : class
    {
        T Add(T objeto);
        T Update(T objeto);
        void Delete(T objeto);
        void Delete(params object[] variavel);
        List<T> GetAll();
        T GetPK(params object[] variavel);
        void SaveChanges();
    }
}
