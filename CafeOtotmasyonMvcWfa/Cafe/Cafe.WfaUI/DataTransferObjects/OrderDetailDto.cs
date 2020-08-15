using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.WfaUI.DataTransferObjects
{
    public class OrderDetailDto
    {
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ProductTotalPrice { get; set; }
    }
}
