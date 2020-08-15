using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Entity.Concretes.Carts
{
    public class MyCart
    {
        Dictionary<int, CartItem> _myCarts = new Dictionary<int, CartItem>();
        public List<CartItem> ListCart => _myCarts.Values.ToList();

        public decimal TotalPrice => _myCarts.Sum(x => x.Value.SubPrice);
        public void Clear()
        {
            _myCarts.Clear();
        }

        public void Add(CartItem cartItem)
        {
            if (_myCarts.ContainsKey(cartItem.ID))
            { 
                _myCarts[cartItem.ID].Amount += cartItem.Amount;
                return; 
            }
            _myCarts.Add(cartItem.ID, cartItem);
        }
        public void Update(params short[] amounts)
        {
            for (int i = 0; i < amounts.Length; i++)
            {            
                _myCarts.ElementAt(i).Value.Amount = amounts[i];
            }
        }
        public void Delete(int id)
        {
            _myCarts.Remove(id);
        }
 
    }
}
