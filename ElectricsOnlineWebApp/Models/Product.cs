using System.Collections.Generic;
using System.Linq;

namespace ElectricsOnlineWebApp
{
    public partial class Product
    {
        private readonly Entities _ctx = new Entities();
        public List<Product> All => _ctx.Products.ToList();
    }
}