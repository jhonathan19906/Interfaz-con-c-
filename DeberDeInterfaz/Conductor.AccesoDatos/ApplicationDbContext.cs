using Microsoft.EntityFrameworkCore;
using System;
using DeberDeInterfaz.Entidad;

namespace Conductor.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Conductor> Condutores { get; set; }

    }
}
