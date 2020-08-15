using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Bll.Abstracts
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        List<Order> GetOrdersBetweendDate(DateTime date1,DateTime date2);
        List<Order> GetOrdersByEmployeeName(string employeeName);
        Order GetOrder(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
