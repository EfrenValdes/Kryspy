using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppPanaderia.Models;
using System.Data.Entity;

namespace WebAppPanaderia.DbConnecion
{
    public class PanaderiaDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<TipoDona> TiposDona { get; set; }
    }
}