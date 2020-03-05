using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Context
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
