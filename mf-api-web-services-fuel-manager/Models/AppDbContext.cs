using Microsoft.EntityFrameworkCore;

namespace mf_api_web_services_fuel_manager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder buider)
        {
           buider.Entity<VeiculoUsuarios>()
                .HasKey(c => new { c.VeiculoId, c.UsuarioId });

            buider.Entity<VeiculoUsuarios>()
                .HasOne(c => c.Veiculo).WithMany(c => c.Usuarios)
                .HasForeignKey(c => c.VeiculoId);

            buider.Entity<VeiculoUsuarios>()
             .HasOne(c => c.Usuario).WithMany(c => c.Veiculos)
             .HasForeignKey(c => c.VeiculoId);
        }

        public DbSet<Veiculo> Veiculos { get; set;}

        public DbSet<Consumo> Consumos { get; set;}
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<VeiculoUsuarios> VeiculoUsuarios { get; set; }
    }
}
