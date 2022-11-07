using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    public class ProductSell
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int stock { get; set; }
        public int sellId { get; set; }

        public ProductSell(int id, int productId, int stock, int sellId)
        {
            this.id = id;
            this.productId = productId;
            this.stock = stock;
            this.sellId = sellId;
        }
    }
}
