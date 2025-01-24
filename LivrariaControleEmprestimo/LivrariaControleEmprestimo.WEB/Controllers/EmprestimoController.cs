using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimoController : Controller
    {
        private LivroClienteEmprestimoService _LivroClienteEmprestimoService = new LivroClienteEmprestimoService();
        private readonly BibliotecaContext _context;
        public IActionResult Index()
        {
            List<LivroClienteEmprestimo> _ListLivroClienteEmprestimo = _LivroClienteEmprestimoService._RepositoryLivroCLienteEmprestimo.GetAll();
            return View(_ListLivroClienteEmprestimo);
        }

        public IActionResult Create()
        {
            var Clientes = _context.Clientes.ToList();
            var Livros = _context.Livros.ToList();

            var listaClientes = Clientes.Select(c => new SelectListItem
            {
                Text = c.Nome,
                Value = c.Id.ToString()
            }).ToList();

            var listaLivros = Livros.Select(l => new SelectListItem
            {
                Text = l.Nome,
                Value = l.Id.ToString()
            }).ToList();

            ViewBag.idCliente = listaClientes;
            ViewBag.idLivros = listaLivros;

            return View();

        }

        [HttpPost]
        public IActionResult Create(LivroClienteEmprestimo Model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _LivroClienteEmprestimoService._RepositoryLivroCLienteEmprestimo.Add(Model);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _LivroClienteEmprestimoService._RepositoryLivroCLienteEmprestimo.Delete(id);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            LivroClienteEmprestimo _LivroClienteEmprestimo = _LivroClienteEmprestimoService._RepositoryLivroCLienteEmprestimo.GetPK(id);
            return View(_LivroClienteEmprestimo);
        }

        public IActionResult Edit(int id)
        {
            LivroClienteEmprestimo _LivroClienteEmprestimo = _LivroClienteEmprestimoService._RepositoryLivroCLienteEmprestimo.GetPK(id);
            return View(_LivroClienteEmprestimo);
        }

        [HttpPost]
        public IActionResult Edit(LivroClienteEmprestimo Model)
        {
            _LivroClienteEmprestimoService._RepositoryLivroCLienteEmprestimo.Update(Model);
            return RedirectToAction("Index");
        }

    }
}
