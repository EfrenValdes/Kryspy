using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppPanaderia.Servicios.Venta.Models
{
    public class TipoDona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}
