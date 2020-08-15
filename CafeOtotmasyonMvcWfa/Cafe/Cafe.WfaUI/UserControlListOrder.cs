using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe.Bll.Abstracts;
using Cafe.Bll.Concretes.Managers;
using Cafe.Dal.Concretes.EntityFramework;
using Cafe.WfaUI.DataTransferObjects;
using Cafe.Entity.Concretes;

namespace Cafe.WfaUI
{
    public partial class UserControlListOrder : UserControl
    {
        IOrderService _orderManager = OrderManager.CreateSingleton(new EfOrderDal());
        IOrderDetailService _orderDetailManager = OrderDetailManager.CreateSingleton(new EfOrderDetailDal());
        int _orderID;
        public UserControlListOrder()
        {
            InitializeComponent();
        }
        private void ListMyOrders()
        {
            dataGridOrder.DataSource = _orderManager.GetOrders().Select(p => new OrderDto()
            {
                OrderID = p.OrderID,
                OrderDate = p.OrderDate,
                EmployeeName=p.Employee==null ?"No Employee":$"{p.Employee.FirstName} {p.Employee.LastName}"
            }).ToList();
        }
        private void UserControlListOrder_Load(object sender, EventArgs e)
        {
            ListMyOrders();
        }

        private void buttonShowAllOrder_Click(object sender, EventArgs e)
        {
            ListMyOrders();
        }
        private void buttonEnterEmployeeName_Click(object sender, EventArgs e)
        {
            string employeeName = textEnterEmployeeName.Text;
            dataGridOrder.DataSource = _orderManager.GetOrdersByEmployeeName(employeeName).Select(p => new OrderDto()
            {
                OrderID = p.OrderID,
                OrderDate = p.OrderDate,
                EmployeeName = p.Employee == null ? "No Employee" : $"{p.Employee.FirstName} {p.Employee.LastName}"
            }).ToList();
        }
        private void buttonEnterByDatetime_Click(object sender, EventArgs e)
        {

            dataGridOrder.DataSource = _orderManager.GetOrdersBetweendDate(dateTimeOrder1.Value,dateTimeOrder2.Value).Select(p => new OrderDto()
            {
                OrderID = p.OrderID,
                OrderDate = p.OrderDate,
                EmployeeName = p.Employee == null ? "No Employee" : $"{p.Employee.FirstName} {p.Employee.LastName}"
            }).ToList();

        }
        private void dataGridOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _orderID = (int)dataGridOrder.CurrentRow.Cells[0].Value;
            dataGridOrderDetail.DataSource = _orderDetailManager.GetOrderDetails(_orderID).Select(p => new OrderDetailDto()
            {
                OrderID = p.OrderID,
                ProductName = p.Product.ProductName,
                ProductAmount = p.ProductAmount,
                UnitPrice = p.Product.UnitPrice,
                ProductTotalPrice = p.ProductTotalPrice
            }).ToList(); 
        }
    }
}
