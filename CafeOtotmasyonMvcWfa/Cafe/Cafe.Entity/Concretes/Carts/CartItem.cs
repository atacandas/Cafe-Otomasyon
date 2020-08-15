using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Entity.Concretes.Carts
{
    public class CartItem
    {
        public CartItem()
        {
            Amount = 1;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; } 
        public decimal SubPrice => Price * Amount;
    }
}
