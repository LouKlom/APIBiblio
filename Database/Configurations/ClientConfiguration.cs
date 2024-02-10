using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> entity)
    {
        entity.ToTable("Clients", "bibliotheque");

        entity.Property(e => e.ID)
            .IsRequired();
        entity.Property(e => e.NOM)
            .HasMaxLength(30)
            .IsRequired();
        entity.Property(e => e.PRENOM)
            .HasMaxLength(30)
            .IsRequired();
        entity.Property(e => e.ADRESSE_MAIL)
            .HasMaxLength(255)
            .HasColumnType("VARCHAR(255)")
            .IsRequired();
        entity.Property(e => e.NUMERO_TELEPHONE)
            .HasMaxLength(10)
            .IsRequired();
        entity.Property(e => e.MOT_DE_PASSE)
            .HasMaxLength(10)
            .IsRequired();
        
        entity.HasIndex(e => e.ID).IsUnique();
        entity.HasIndex(e => e.NUMERO_TELEPHONE).IsUnique();
    }
}