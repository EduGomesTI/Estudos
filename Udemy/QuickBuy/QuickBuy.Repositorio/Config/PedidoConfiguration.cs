using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.DataPedido)
                .IsRequired();
            builder
                .Property(p => p.UsuarioId)
                .IsRequired();
            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();
            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(8);
            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(2);
            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(30);
            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.NumeroEndereco)
                .HasMaxLength(4);
            builder
                .HasOne(p => p.Usuario);
            builder
                .HasMany(p => p.ItensPedido)
                .WithOne(i => i.Pedido);
        }
    }
}

