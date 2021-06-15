using Iptv.Domain.Entities;
using System.Linq;

namespace Iptv.Domain.Abstract
{
    public interface ICartRepository
    {
        IQueryable<Cart> carts { get; }
        void add(Cart data);
    }
}
