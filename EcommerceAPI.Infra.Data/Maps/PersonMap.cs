using EcommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.Infra.Data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("IdPessoa")
                .UseIdentityColumn();

            builder.Property(x => x.Document)
                .HasColumnName("Documento");

            builder.Property(x => x.Name)
                .HasColumnName("Nome");

            builder.Property(x => x.Phone)
                .HasColumnName("Celular");

            builder.HasMany(x => x.Purchases)
                .WithOne(x => x.Person)
                .HasForeignKey(x => x.PersonId);
        }
    }
}
