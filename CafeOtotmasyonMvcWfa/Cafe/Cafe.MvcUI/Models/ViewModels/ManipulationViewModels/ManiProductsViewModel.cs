using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cafe.MvcUI.Models.ViewModels.ManipulationViewModels
{
    public class ManiProductsViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
        public string ButtonName { get; set; }
    }
}