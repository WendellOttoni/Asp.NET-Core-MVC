using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivrariaControleEmprestimo.DATA.Repositories;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class ClienteService
    {
        public RepositoryCliente _RepositoryCliente { get; set; }

        public ClienteService()
        {
            _RepositoryCliente = new RepositoryCliente();
        }
    }
}
