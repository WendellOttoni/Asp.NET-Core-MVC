using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivrariaControleEmprestimo.DATA.Repositories;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroService
    {
        public RepositoryLivro _RepositoryLivro { get; set; }

        public LivroService()
        {
            _RepositoryLivro = new RepositoryLivro();
        }
    }
}
