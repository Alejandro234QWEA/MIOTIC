using Microsoft.EntityFrameworkCore;
using MIOTIC.Models;


namespace MIOTIC.Contexto
{
    public class MiContext: DbContext

    {
        public MiContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contrato> Contrato { get; set; }

    }
}
