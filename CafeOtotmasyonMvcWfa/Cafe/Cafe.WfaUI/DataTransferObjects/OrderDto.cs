using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.WfaUI.DataTransferObjects
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
