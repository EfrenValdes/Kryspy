using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppPanaderia.Servicios.Venta.Models;
using WebAppPanaderia.Servicios.Venta.DbConnecion;
using Microsoft.AspNetCore.Authorization;


namespace WebAppPanaderia.Servicios.Venta.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class VentaController : Controller
    {
        private readonly ILogger<VentaController> _logger;
        private readonly WebAppPanaderiaContext _context;
        public VentaController(ILogger<VentaController> logger, WebAppPanaderiaContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET api/ventas
        [HttpGet]
        public IActionResult GetAllVentas()
        {
            try
            {
                var ventas = _context.Ventas.ToList();
                return Ok(ventas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener todas las ventas");
                return StatusCode(500, "Error interno del servidor");
            }
        }
        // GET api/ventas/5
        [HttpGet("{id}")]
        public IActionResult GetVenta(int id)
        {
            try
            {
                var venta = _context.Ventas.Find(id);
                if (venta == null)
                {
                    return NotFound();
                }
                return Ok(venta);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener una venta por ID");
                return StatusCode(500, "Error interno del servidor");
            }
        }
        // POST api/ventas
        [HttpPost]
        public IActionResult CreateVenta(Venta.Models.Venta venta)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.Ventas.Add(venta);
                _context.SaveChanges();

                return CreatedAtAction(nameof(GetVenta), new { id = venta.Id }, venta);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear una venta");
                return StatusCode(500, "Error interno del servidor");
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
