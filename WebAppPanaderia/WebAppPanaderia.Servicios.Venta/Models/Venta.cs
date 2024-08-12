using System.ComponentModel.DataAnnotations;
using System;

namespace WebAppPanaderia.Servicios.Venta.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int TipoDonaId { get; set; }
        public TipoDona TipoDona { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
