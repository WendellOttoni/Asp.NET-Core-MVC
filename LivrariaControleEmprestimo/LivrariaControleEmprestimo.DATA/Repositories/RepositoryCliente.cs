using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente    
    {
        public RepositoryCliente(bool SaveChanges = true) : base(SaveChanges)
        {
                
        }
    }
}
