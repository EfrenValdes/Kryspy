using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPanaderia.DbConnecion;
using WebAppPanaderia.Models;
using WebAppPanaderia.ViewModel;

namespace WebAppPanaderia.Controllers
{
    public class HomeController : Controller
    {

        private readonly PanaderiaDbContext _context;

        public HomeController(PanaderiaDbContext context)
        {
            _context = context;
        }

        // Registro de clientes
        [HttpPost]
        public ActionResult RegistrarCliente(Registro registro)
        {
            Cliente cliente = registro.Cliente;
            Venta venta = registro.Venta;
            _context.Clientes.Add(cliente);
            _context.Ventas.Add(venta);
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
