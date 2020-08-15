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
using Cafe.Entity.Concretes.Carts;

namespace Cafe.WfaUI
{
    public partial class UserControlOrderPage : UserControl
    {
        MyCart _myCart = new MyCart();
        int _idProduct;
        int _idCategory;
        IProductService _productManager = ProductManager.CreateSingleton(new EfProductDal());
        IEmployeeService _employeeManager = EmployeeManager.CreateSingleton(new EfEmployeeDal());
        IOrderService _orderManager = OrderManager.CreateSingleton(new EfOrderDal());
        IOrderDetailService _orderDetailManager = OrderDetailManager.CreateSingleton(new EfOrderDetailDal());
        public UserControlOrderPage()
        {
            InitializeComponent();
        }
        private void UserControlOrderPage_Load(object sender, EventArgs e)
        {
            ListMyProducts();
            FillCategoryComboBox();
        }
        private void ListMyProducts()
        {
            dataGridProduct.DataSource = _productManager.GetProducts().Select(p => new ProductDto()
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                CategoryName = p.Category.CategoryName,
                UnitPrice = (decimal)p.UnitPrice,
                UnitsInStock = (int)p.UnitsInStock
            }).ToList();
        }
        private void FillCategoryComboBox()
        {
            comboBoxCategories.DataSource = new CategoryManager(new EfCategoryDal()).GetCategories();
            comboBoxCategories.DisplayMember = "CategoryName";
            comboBoxCategories.ValueMember = "CategoryID";
        }
        private void buttonShowAllProducts_Click(object sender, EventArgs e)
        {
            dataGridProduct.DataSource = null;
            ListMyProducts();
        }
        private void buttonEnterByCatName_Click(object sender, EventArgs e)
        {
            _idCategory = (int)comboBoxCategories.SelectedValue;
            dataGridProduct.DataSource = _productManager.GetProductsByCatId(_idCategory).Select(p => new ProductDto()
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                CategoryName = p.Category.CategoryName,
                UnitPrice = (decimal)p.UnitPrice,
                UnitsInStock = (int)p.UnitsInStock
            }).ToList();
        }
        private void buttonEnterProductName_Click(object sender, EventArgs e)
        {
            if (textEnterProductName.Text == "")
            {
                MessageBox.Show("Ürün Adı giriniz");
            }
            else
            {
                string productName = textEnterProductName.Text;
                dataGridProduct.DataSource = _productManager.GetProductsByProductName(productName).Select(p => new ProductDto()
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    CategoryName = p.Category.CategoryName,
                    UnitPrice = (decimal)p.UnitPrice,
                    UnitsInStock = (int)p.UnitsInStock
                }).ToList();
            }
        }
        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idProduct = (int)dataGridProduct.CurrentRow.Cells[0].Value;
            labelProductName.Text = (string)dataGridProduct.CurrentRow.Cells[1].Value;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            labelTotalPrice.Text = "0";
            _myCart.Clear();

        }
        private void listBox1_Click(object sender, EventArgs e)
        {
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
        }
        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            int amount = (int)numericUpDown1.Value;
            if (amount>0)
            {
                Product product = _productManager.GetProduct(_idProduct);
                CartItem cartItem = new CartItem()
                {
                    ID = product.ProductID,
                    Amount = amount,
                    Name = product.ProductName,
                    Price = (decimal)product.UnitPrice
                };
                _myCart.Add(cartItem);
                
                listBox1.Items.Clear();
                foreach (CartItem item in _myCart.ListCart)
                {
                    listBox1.Items.Add($"Product Name={item.Name} Amount={item.Amount.ToString()} Price={item.Price.ToString()} Sub Price= {(item.SubPrice).ToString()}");
                }
                labelTotalPrice.Text = _myCart.TotalPrice.ToString();
            }
            else
            {
                MessageBox.Show("Ürün Sayısını Giriniz");
            }
        }
        private void buttonTakeOrder_Click(object sender, EventArgs e)
        {
            FormAdminPanel myUserControl = (FormAdminPanel)ParentForm;
            Employee LoginEmployee =_employeeManager.GetEmployee(myUserControl.Text);
            Order order = new Order()
            {
                OrderDate = DateTime.Now,
                EmployeeID = LoginEmployee.EmployeeID,
                OrderTotalPrice = decimal.Parse(labelTotalPrice.Text)
            };
            _orderManager.AddOrder(order);

            foreach (CartItem cartItem in _myCart.ListCart)
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderID = order.OrderID,
                    ProductID = cartItem.ID,
                    ProductAmount = cartItem.Amount,
                    UnitPrice= cartItem.Price,
                    ProductTotalPrice = cartItem.Price * cartItem.Amount
                };
                _orderDetailManager.AddOrderDetail(orderDetail);
            }

            MessageBox.Show("Yeni Sipariş Oluştu ");
        }

        
    }
}
