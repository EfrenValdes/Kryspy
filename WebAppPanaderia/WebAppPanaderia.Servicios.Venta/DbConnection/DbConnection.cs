using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppPanaderia.Servicios.Venta.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebAppPanaderia.Servicios.Venta.DbConnecion
{
    public class WebAppPanaderiaContext : DbContext
    {
        public WebAppPanaderiaContext(DbContextOptions<WebAppPanaderiaContext> options)
            : base(options)
        {
        }

        public DbSet<Venta.Models.Venta> Ventas { get; set; }
        public DbSet<TipoDona> TiposDona { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venta.Models.Venta>()
                .HasOne(v => v.TipoDona)
                .WithMany(td => td.Ventas)
                .HasForeignKey(v => v.TipoDonaId);
        }
    }

}