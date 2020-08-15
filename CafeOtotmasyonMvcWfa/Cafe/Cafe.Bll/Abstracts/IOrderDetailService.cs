using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Bll.Abstracts
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetOrderDetails();
        List<OrderDetail> GetOrderDetails(int orderId);
        OrderDetail GetOrderDetail(int id);
        void AddOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(Order orderDetail);
        void DeleteOrderDetail(int id);
    }
}
