using Microsoft.EntityFrameworkCore;

using MarketPlace.Model;

namespace MarketPlace.DBContext
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions<MarketContext> options) : base(options) { }

        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItemCarrinho> itemCarrinho { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}