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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;
        private static OrderDetailManager _orderDetailManager;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }
        public static OrderDetailManager CreateSingleton(IOrderDetailDal orderDetailDal)
        {
            if (_orderDetailManager == null)
            {
                _orderDetailManager = new OrderDetailManager(orderDetailDal);
            }

            return _orderDetailManager;
        }
        public void AddOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail != null)
            {
                _orderDetailDal.Add(orderDetail);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public void DeleteOrderDetail(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetOrderDetails()
        {
            return _orderDetailDal.GetOrderDetailWithProductName();
        }

        public void UpdateOrderDetail(Order orderDetail)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            return _orderDetailDal.GetOrderDetailWithProductName(p => p.OrderID == orderId);
        }
    }
}
