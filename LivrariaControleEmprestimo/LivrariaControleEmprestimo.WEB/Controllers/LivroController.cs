using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class LivroController : Controller
    {
        private LivroService _LivroService = new LivroService();

        // Listando os livros na tela index
        public IActionResult Index()
        {
            List<Livro> _listLivro = _LivroService._RepositoryLivro.GetAll();
            return View(_listLivro);
        }

        // GET: Livro/Details
        public IActionResult Details(int id)
        {
            Livro _Livro = _LivroService._RepositoryLivro.GetPK(id);
            return View(_Livro);
        }

        // GET: Livro/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _LivroService._RepositoryLivro.Add(model);

            return RedirectToAction("Index");
        }

        // GET: Livro/Edit/5
        public IActionResult Edit(int id)
        {
            Livro _Livro = _LivroService._RepositoryLivro.GetPK(id);
            return View(_Livro);
        }

        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            _LivroService._RepositoryLivro.Update(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _LivroService._RepositoryLivro.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
