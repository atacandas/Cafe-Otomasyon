using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cafe.MvcUI.Models.ViewModels.ManipulationViewModels
{
    public class ManiEmployeesViewModel
    {
        public Employee Employee { get; set; }
        public List<Title> Titles { get; set; }
        public string ButtonName { get; set; }
    }
}