using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivrariaControleEmprestimo.DATA.Repositories;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroClienteEmprestimoService
    {
        public RepositoryLivroClienteEmprestimo _RepositoryLivroCLienteEmprestimo { get; set; }

        public LivroClienteEmprestimoService()
        {
            _RepositoryLivroCLienteEmprestimo = new RepositoryLivroClienteEmprestimo();
        }
    }
}
