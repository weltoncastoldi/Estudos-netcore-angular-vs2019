﻿using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repository.Config;

namespace QuickBuy.Repository.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public DbSet<FormaPagamento> FormasPagamentos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() {Id = 1, Nome = "Boleto", Descricao = "Forma de pagamento com boleto" },
                new FormaPagamento() {Id = 2, Nome = "Cartão de Crédito", Descricao = "Forma de pagamento com cartão de crédito" },
                new FormaPagamento() {Id = 3, Nome = "Depóstio", Descricao = "Forma de pagamento em depósito" });
            base.OnModelCreating(modelBuilder);
        }
    }
}