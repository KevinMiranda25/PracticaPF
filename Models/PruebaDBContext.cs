using Microsoft.EntityFrameworkCore;

namespace PracticaESFE.AppMVC.Models
{
    public class PruebaDBContext : DbContext
    {
        public PruebaDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Producto> Producto { get; set; }
    }
}
