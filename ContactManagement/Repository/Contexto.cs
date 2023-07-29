using ContactManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.Repository
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Contexto(DbContextOptions<Contexto> options)
         : base(options)
        {
        }
    }
}
