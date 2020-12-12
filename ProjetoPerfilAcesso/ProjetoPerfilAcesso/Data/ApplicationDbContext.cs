using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ProjetoPerfilAcesso.Models;

namespace ProjetoPerfilAcesso.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<AcessoTipoUsuario> AcessoTipoUsuario { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuario { get; set; }
        public DbSet<IdentityUser> Usuario { get; set; }
    }
}
