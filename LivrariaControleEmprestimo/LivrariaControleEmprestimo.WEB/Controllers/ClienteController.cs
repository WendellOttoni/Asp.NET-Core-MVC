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
    }
}
