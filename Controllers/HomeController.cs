using Microsoft.AspNetCore.Mvc;
using LHPet.Data;
using LHPet.Models;

namespace LHPet.Controllers
{
    public class HomeController : Controller
    {
        private readonly LHPetContext _context;

        public HomeController(LHPetContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.listaClientes = _context.Clientes.ToList();
            ViewBag.listaFornecedores = _context.Fornecedores.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult CreateCliente() => View();

        [HttpPost]
        public IActionResult CreateCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        [HttpGet]
        public IActionResult CreateFornecedor() => View();

        [HttpPost]
        public IActionResult CreateFornecedor(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _context.Fornecedores.Add(fornecedor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }
    }
}
