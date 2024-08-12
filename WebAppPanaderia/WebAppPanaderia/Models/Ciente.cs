using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPanaderia.Models
{
    // Modelo Cliente
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    }
}