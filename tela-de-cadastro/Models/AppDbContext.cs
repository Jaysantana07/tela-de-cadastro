using Microsoft.EntityFrameworkCore;

namespace tela_de_cadastro.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       
        public DbSet<Cadastro> Veiculos { get; set; }
    }
}
