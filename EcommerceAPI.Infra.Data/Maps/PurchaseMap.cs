﻿using EcommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.Infra.Data.Maps
{
    public class PurchaseMap : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("Compra");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("IdCompra")
                .UseIdentityColumn();

            builder.Property(x => x.PersonId)
                .HasColumnName("IdPessoa");

            builder.Property(x => x.ProductId)
                .HasColumnName("IdProduto");

            builder.Property(x => x.Date)
                .HasColumnName("DataCompra");

            builder.HasOne(x => x.Person)
                .WithMany(x => x.Purchases);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Purchases);
        }
    }
}
