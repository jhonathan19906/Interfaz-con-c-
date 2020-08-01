using Conductor.Entidad;
using Microsoft.EntityFrameworkCore;


namespace Profeciones.AccesoDato
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Conductor> Conductores { get; set; }
    }
}
