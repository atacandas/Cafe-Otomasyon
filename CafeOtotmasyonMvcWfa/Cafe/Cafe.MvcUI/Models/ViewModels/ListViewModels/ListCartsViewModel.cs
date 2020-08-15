using Cafe.Entity.Concretes.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cafe.MvcUI.Models.ViewModels.ListViewModels
{

    public class ListCartsViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
