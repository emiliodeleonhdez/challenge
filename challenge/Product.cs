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
        public string ProducDescription { get; set; }
        public int Cost { get; set; }
        public int SellPrice { get; set; }
        public int Stock { get; set; }
        public int UserId { get; set; }

        public Product()
        {
            ProducDescription = string.Empty;
        }


        public Product(int id, string productDescription, int cost, int priceOfSell, int stock, int userId)
        {
            Id = id;
            this.ProducDescription = productDescription;
            this.Cost = cost;
            this.SellPrice = priceOfSell;
            this.Stock = stock;
            this.UserId = userId;
        }

    }
}
