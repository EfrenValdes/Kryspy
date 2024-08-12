using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPanaderia.DbConnecion;

namespace WebAppPanaderia.Controllers
{
    
    public class VentaController : Controller
    {
        private readonly PanaderiaDbContext _context;

        // Consulta de ventas por tipo de dona y cantidad
        public ActionResult Ventas()
        {
            var ventas = _context.Ventas
                .Where(v => v.TipoDona.Nombre == "Donas de chocolate" && v.Cantidad > 10)
                .ToList();
            return View(ventas);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}