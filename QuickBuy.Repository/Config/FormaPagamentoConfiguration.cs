using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;
using System;

namespace QuickBuy.Repository.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);
            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(i => i.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
