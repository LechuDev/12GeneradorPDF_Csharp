using Microsoft.EntityFrameworkCore;
using ReportApp.Models;

namespace ReportApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venta>().HasData(
                new Venta { Id = 1, Fecha = DateTime.Now.AddDays(-2), Producto = "Laptop Gamer", Monto = 25000 },
                new Venta { Id = 2, Fecha = DateTime.Now.AddDays(-1), Producto = "Mouse Inalámbrico", Monto = 800 },
                new Venta { Id = 3, Fecha = DateTime.Now, Producto = "Monitor 4K", Monto = 7000 }
            );
        }
    }
}