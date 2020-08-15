using Cafe.Bll.Abstracts;
using Cafe.Dal.Abstracts;
using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Bll.Concretes.Managers
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        private static OrderManager _orderManager;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public static OrderManager CreateSingleton(IOrderDal orderDal)
        {
            if (_orderManager == null)
            {
                _orderManager = new OrderManager(orderDal);
            }

            return _orderManager;
        }
        public void AddOrder(Order order)
        {
            if (order != null)
            {
                _orderDal.Add(order);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public void DeleteOrder(int id)
        {
            if (id > 1)
            {
                _orderDal.Delete(new Order { OrderID = id });
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public Order GetOrder(int id)
        {
            return _orderDal.Get(p => p.OrderID == id);
        }

        public List<Order> GetOrders()
        {
            return _orderDal.GetOrdersByEmployeeName();
        }

        public void UpdateOrder(Order order)
        {
            if (order != null)
            {
                _orderDal.Update(order);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public List<Order> GetOrdersByEmployeeName(string employeeName)
        {
            return _orderDal.GetOrdersByEmployeeName(p => p.Employee.FirstName.Contains(employeeName)||p.Employee.LastName.Contains(employeeName));
        }

        public List<Order> GetOrdersBetweendDate(DateTime date1, DateTime date2)
        {
            return _orderDal.GetOrdersByEmployeeName(p => p.OrderDate > date1 && p.OrderDate < date2);
        }
    }
}
