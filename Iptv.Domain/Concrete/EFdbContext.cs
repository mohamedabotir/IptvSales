using Iptv.Domain.Entities;
using System.Data.Entity;

namespace Iptv.Domain.Concrete
{
    class EFdbContext : DbContext
    {
        public DbSet<Plan> plans { set; get; }
        public DbSet<Balance> balances { set; get; }
        public DbSet<Cart> carts { set; get; }
    }
}
