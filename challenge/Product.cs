using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    public class Product
    {
        public int Id { get; set; }
        public string productDescription { get; set; }
        public int cost { get; set; }
        public int priceOfSell { get; set; }
        public int stock { get; set; }
        public int userId { get; set; }


        public Product(int id, string productDescription, int cost, int priceOfSell, int stock, int userId)
        {
            Id = id;
            this.productDescription = productDescription;
            this.cost = cost;
            this.priceOfSell = priceOfSell;
            this.stock = stock;
            this.userId = userId;
        }

    }
}
