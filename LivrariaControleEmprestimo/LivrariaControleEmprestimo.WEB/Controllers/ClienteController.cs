using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService _ClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> _listCliente = _ClienteService._RepositoryCliente.GetAll();
            return View(_listCliente);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Cliente Model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _ClienteService._RepositoryCliente.Add(Model);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _ClienteService._RepositoryCliente.Delete(id);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Cliente _Cliente = _ClienteService._RepositoryCliente.GetPK(id);       
            return View(_Cliente);
        }

        public IActionResult Edit(int id)
        {
            Cliente _Cliente = _ClienteService._RepositoryCliente.GetPK(id);
            return View(_Cliente);
        }

        [HttpPost]  
        public IActionResult Edit(Cliente Model)
        {
            _ClienteService._RepositoryCliente.Update(Model);
            return RedirectToAction("Index");
        }
    }
}
