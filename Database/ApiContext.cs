using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        // Vous pouvez ajouter d'autres DbSet pour d'autres modèles ici

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Vous pouvez ajouter des configurations de modèle personnalisées ici
        }
    }
}
