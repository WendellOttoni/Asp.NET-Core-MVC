﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livro>, IRepositoryLivro
    {
        public RepositoryLivro(bool SaveChanges = true) : base(SaveChanges)
        {
             
        }
    }
}
