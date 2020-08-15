using Cafe.Bll.Abstracts;
using Cafe.Bll.Concretes.Managers;
using Cafe.Dal.Concretes.EntityFramework;
using Cafe.Entity.Concretes;
using Cafe.Entity.Concretes.Carts;
using Cafe.MvcUI.Attributes.AuthorizeAttributes;
using Cafe.MvcUI.Models.ViewModels.ListViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace Cafe.MvcUI.Controllers
{
    [EmployeeAuthorizeAttribute]
    public class AdminOrderController : Controller
    {
        IProductService _productManager = ProductManager.CreateSingleton(new EfProductDal());
        IOrderService _orderManager = OrderManager.CreateSingleton(new EfOrderDal());
        IOrderDetailService _orderDetailManager = OrderDetailManager.CreateSingleton(new EfOrderDetailDal());
        [HttpGet]
        public ActionResult ListProductsForOrder()
        {
            ListProductsViewModel model = new ListProductsViewModel()
            {
                Products = _productManager.GetProducts()
            };
            return View(model);
        }  
        [HttpGet]
        public ActionResult AddCart(int id)
        {
            MyCart myCart;
            if (Session["cart"] == null)
            {
                myCart = new MyCart();
            }
            else
            {
                myCart = Session["cart"] as MyCart;
            }
            Product product = _productManager.GetProduct(id);
            CartItem cartItem = new CartItem();
            cartItem.ID = product.ProductID;
            cartItem.Name = product.ProductName;
            cartItem.Price = (decimal)product.UnitPrice;
            myCart.Add(cartItem);
            Session["cart"] = myCart;
            return RedirectToAction("ListProductsForOrder");
        }
        [HttpGet]
        public ActionResult ListCartItem()
        {
            if (Session["cart"] != null)
            {
                MyCart myCart = Session["cart"] as MyCart;

                ListCartsViewModel model = new ListCartsViewModel
                {
                    CartItems = myCart.ListCart,
                    TotalPrice = myCart.TotalPrice
                };

                return View(model);
            }
            return RedirectToAction("ListProductsForOrder");
        }
        [HttpGet]
        public ActionResult DeleteCartItem(int id)
        {
            if (Session["cart"] != null)
            {
                MyCart myCart = Session["cart"] as MyCart;
                myCart.Delete(id);
            }

            return RedirectToAction("ListCartItem");
        }
        [HttpPost]
        public ActionResult UpdateCart(params short[] amounts)
        {
            if (Session["cart"] != null)
            {
                MyCart myCart = Session["cart"] as MyCart;
                myCart.Update(amounts);
            }
            return RedirectToAction("ListCartItem");
        }
        [HttpGet]
        public ActionResult TakeOrder()
        {
            if (Session["cart"] != null)
            {
                Employee loginEmployee = Session["myLogin"] as Employee;
                MyCart myCart = Session["cart"] as MyCart;
                Order order = new Order()
                {
                    OrderDate = DateTime.Now,
                    EmployeeID = loginEmployee.EmployeeID,
                    OrderTotalPrice = myCart.TotalPrice
                };
                _orderManager.AddOrder(order);
                foreach (CartItem cartItem in myCart.ListCart)
                {
                    OrderDetail orderDetail = new OrderDetail
                    {
                        OrderID = order.OrderID,
                        ProductID = cartItem.ID,
                        ProductAmount = cartItem.Amount,
                        UnitPrice = cartItem.Price,
                        ProductTotalPrice = cartItem.Price * cartItem.Amount
                    };
                    _orderDetailManager.AddOrderDetail(orderDetail);
                    Product product =  _productManager.GetProduct(cartItem.ID);
                    product.UnitsInStock -= cartItem.Amount;
                    _productManager.UpdateProduct(product);
                }
                TempData["message"] = "Yeni sipariş oluştu ve stoklar güncellendi.";
            }
            Session["cart"] = null;
            return RedirectToAction("ListOrder");
        }
        [HttpGet]
        public ActionResult ListOrder(int sayfa=1)
        {
            var orders = _orderManager.GetOrders().ToPagedList(sayfa, 10);
            return View(orders);
        }
        [HttpGet]
        public ActionResult ShowOrderDetail(int id)
        {
            ListOrderDetailViewModel model = new ListOrderDetailViewModel()
            {
                OrderDetails = _orderDetailManager.GetOrderDetails(id),
            };
            return View(model);
        }

    }
}