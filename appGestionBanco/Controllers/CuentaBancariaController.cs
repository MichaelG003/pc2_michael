using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appGestionBanco.Data;
using appGestionBanco.Models;

namespace appGestionBanco.Controllers
{
    public class CuentaBancariaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<CuentaBancariaController> _logger;

        // Constructor único que inyecta ApplicationDbContext y ILogger
        public CuentaBancariaController(ApplicationDbContext context, ILogger<CuentaBancariaController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var accounts = _context.CuentaBancos.ToList();
            return View(accounts);
        }

        public IActionResult CrearCuenta()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearCuenta([Bind("NombreTitular,TipoCuenta,SaldoInicial,Email")] CuentaBanco CuentaBancos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(CuentaBancos);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(CuentaBancos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
