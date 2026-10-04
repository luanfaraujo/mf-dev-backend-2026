using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2026.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Cada tabela nova precisa de uma linha aqui
        // Fazer add-migration e update-database após cada uma
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
