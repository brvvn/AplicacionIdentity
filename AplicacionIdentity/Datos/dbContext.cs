using AplicacionIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AplicacionIdentity.Datos
{
    public class dbContext : IdentityDbContext
    {
        public dbContext(DbContextOptions options) :base(options)
        {

        }
        //Agregamos el Modelo
        public DbSet<Usuario> claseUsuario { get; set; }
    }
}
