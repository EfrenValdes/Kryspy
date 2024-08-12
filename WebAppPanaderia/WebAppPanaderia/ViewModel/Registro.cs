using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppPanaderia.Models;

namespace WebAppPanaderia.ViewModel
{
    public class Registro
    {
        public Cliente Cliente { get; set; }
        public Venta Venta { get; set; }
    }
}