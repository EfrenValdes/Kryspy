using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppPanaderia.Models;

namespace WebAppPanaderia.Models
{
    // Modelo Venta
    public class Venta
    {
        public int Id { get; set; }
        public int IdTipoDona { get; set; }
        public int Cantidad { get; set; }
        public TipoDona TipoDona { get; set; }
    }
}