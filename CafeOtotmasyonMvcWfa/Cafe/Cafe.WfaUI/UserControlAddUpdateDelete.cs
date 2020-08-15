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
    public partial class UserControlAddUpdateDelete : UserControl
    {
        int _idProduct;
        int _idCategory;
        int _idEmployee;
        int _idTitle;
        IProductService _productManager = ProductManager.CreateSingleton(new EfProductDal());
        ICategoryService _categoryManager = CategoryManager.CreateSingleton(new EfCategoryDal());
        IEmployeeService _employeeManager = EmployeeManager.CreateSingleton(new EfEmployeeDal());
        ITitleService _titleManager = TitleManager.CreateSingleton(new EfTitleDal());
        public UserControlAddUpdateDelete()
        {
            InitializeComponent();
        }

        private void UserControlAddUpdateDelete_Load(object sender, EventArgs e)
        {
            ListMyCategories();
            ListMyEmployees();
            ListMyProducts();
            ListMyTitles();
            FillCategoryComboBoxes();
            FillTitleComboBoxes();
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
        private void ListMyCategories()
        {
            dataGridCategory.DataSource = _categoryManager.GetCategories().Select(p => new CategoryDto()
            {
                CategoryID = p.CategoryID,
                CategoryName = p.CategoryName,
                Description = p.Description
            }).ToList();
        }
        private void ListMyTitles()
        {
            dataGridTitle.DataSource = _titleManager.GetTitles().Select(p => new TitleDto()
            {
                TitleID = p.TitleID,
                TitleName = p.TitleName,
                Description = p.Description
            }).ToList();
        }
        private void ListMyEmployees()
        {
            dataGridEmployee.DataSource = _employeeManager.GetEmployees().Select(p => new EmployeeDto()
            {
                EmployeeID = p.EmployeeID,
                FirstName = p.FirstName,
                LastName = p.LastName,
                TitleName = p.Title.TitleName,
                Address = p.Address,
                Phone = p.Phone,
                UserName = p.UserName,
                Password = p.Password
            }).ToList();
        }
        private void FillCategoryComboBoxes()
        {
            comboCategoryName.DataSource = new CategoryManager(new EfCategoryDal()).GetCategories();
            comboCategoryName.DisplayMember = "CategoryName";
            comboCategoryName.ValueMember = "CategoryID";
            comboAddProductCategory.DataSource = new CategoryManager(new EfCategoryDal()).GetCategories();
            comboAddProductCategory.DisplayMember = "CategoryName";
            comboAddProductCategory.ValueMember = "CategoryID";
        }
        private void FillTitleComboBoxes()
        {
            comboAddEmpTitle.DataSource = new TitleManager(new EfTitleDal()).GetTitles();
            comboAddEmpTitle.DisplayMember = "TitleName";
            comboAddEmpTitle.ValueMember = "TitleID";
            comboEditEmpTitle.DataSource= new TitleManager(new EfTitleDal()).GetTitles();
            comboEditEmpTitle.DisplayMember = "TitleName";
            comboEditEmpTitle.ValueMember = "TitleID";
        }


        #region ProductManipulation

        private void ClearProductTexts()
        {
            textAddProductStock.Clear();
            textProductAddPrice.Clear();
            textProductsAddName.Clear();
            comboAddProductCategory.SelectedItem = null;
            textProductName.Clear();
            textUnitPrice.Clear();
            textUnitStock.Clear();
            comboCategoryName.SelectedItem = null;
        }
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductName = textProductsAddName.Text,
                CategoryID = (int)comboAddProductCategory.SelectedValue,
                UnitPrice = decimal.Parse(textProductAddPrice.Text),
                UnitsInStock = int.Parse(textAddProductStock.Text)
            };
            _productManager.AddProduct(product);
            MessageBox.Show("Ürün Eklendi ");
            ListMyProducts();
            ClearProductTexts();
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idProduct = (int)dataGridProduct.CurrentRow.Cells[0].Value;
            textProductName.Text = (string)dataGridProduct.CurrentRow.Cells[1].Value;
            comboCategoryName.Text = (string)dataGridProduct.CurrentRow.Cells[2].Value;
            textUnitPrice.Text = dataGridProduct.CurrentRow.Cells[3].Value.ToString();
            textUnitStock.Text = dataGridProduct.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonProductUpdate_Click(object sender, EventArgs e)
        {
            Product product = _productManager.GetProduct(_idProduct);

            product.ProductName = textProductName.Text;
            product.UnitPrice = decimal.Parse(textUnitPrice.Text);
            product.UnitsInStock = int.Parse(textUnitStock.Text);
            product.CategoryID = (int)comboCategoryName.SelectedValue;

            _productManager.UpdateProduct(product);

            MessageBox.Show("Veri guncellendi");

            ListMyProducts();
            ClearProductTexts();
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            _productManager.DeleteProduct(_idProduct);
            MessageBox.Show("Ürün silindi");
            ListMyProducts();
            ClearProductTexts();
        }
        #endregion

        #region CategoryManipulation
        private void ClearCategoryTexts()
        {
            textAddCategoryName.Clear();
            textAddCategoryDescription.Clear();
            textEditCategoryDescription.Clear();
            textEditCategoryName.Clear();
        }
        private void dataGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idCategory = (int)dataGridCategory.CurrentRow.Cells[0].Value;
            textEditCategoryName.Text = (string)dataGridCategory.CurrentRow.Cells[1].Value;
            textEditCategoryDescription.Text = (string)dataGridCategory.CurrentRow.Cells[2].Value;
        }
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                CategoryName = textAddCategoryName.Text,
                Description = textAddCategoryDescription.Text
            };
            _categoryManager.AddCategory(category);
            MessageBox.Show("Category Eklendi ");
            ListMyCategories();
            ClearCategoryTexts();
            FillCategoryComboBoxes();
        }
        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            Category category = _categoryManager.GetCategory(_idCategory);

            category.CategoryName = textEditCategoryName.Text;
            category.Description = textEditCategoryDescription.Text;

            _categoryManager.UpdateCategory(category);

            MessageBox.Show("Category guncellendi");

            ListMyCategories();
            ClearCategoryTexts();
            FillCategoryComboBoxes();
        }
        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            _categoryManager.DeleteCategory(_idCategory);
            MessageBox.Show("Category silindi");
            ListMyCategories();
            ClearCategoryTexts();
            FillCategoryComboBoxes();
        }
        #endregion

        #region TitleManipulation
        private void ClearTitleTexts()
        {
            textAddTitleName.Clear();
            textAddTitleDescription.Clear();
            textEditTitleName.Clear();
            textEditTitleDescription.Clear();
        }
        private void dataGridTitle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idTitle = (int)dataGridTitle.CurrentRow.Cells[0].Value;
            textEditTitleName.Text = (string)dataGridTitle.CurrentRow.Cells[1].Value;
            textEditTitleDescription.Text = (string)dataGridTitle.CurrentRow.Cells[2].Value;
        }
        private void buttonAddTitle_Click(object sender, EventArgs e)
        {
            Title title = new Title()
            {
                TitleName = textAddTitleName.Text,
                Description = textAddTitleDescription.Text
            };
            _titleManager.AddTitle(title);
            MessageBox.Show("Title Eklendi ");
            ListMyTitles();
            ClearTitleTexts();
            FillTitleComboBoxes();
        }
        private void buttonUpdateTitle_Click(object sender, EventArgs e)
        {
            Title title = _titleManager.GetTitle(_idTitle);

            title.TitleName = textEditTitleName.Text;
            title.Description = textEditTitleDescription.Text;

            _titleManager.UpdateTitle(title);

            MessageBox.Show("Title guncellendi");

            ListMyTitles();
            ClearTitleTexts();
            FillTitleComboBoxes();
        }
        private void buttonDeleteTitle_Click(object sender, EventArgs e)
        {
            _titleManager.DeleteTitle(_idTitle);
            MessageBox.Show("Title silindi");
            ListMyTitles();
            ClearTitleTexts();
            FillTitleComboBoxes();
        }
        #endregion

        #region EmployeeManipulation
        private void ClearEmployeeTexts()
        {
            textAddEmpFirstName.Clear();
            textAddEmpLastName.Clear();
            comboAddEmpTitle.SelectedItem = null;
            textAddEmpAddress.Clear();
            textAddEmpPhone.Clear();
            textAddEmpUserName.Clear();
            textAddEmpPassword.Clear();
            textEditEmpFirstName.Clear();
            textEditEmpLastName.Clear();
            comboEditEmpTitle.SelectedItem = null;
            textEditEmpAddress.Clear();
            textEditEmpPhone.Clear();
            textEditEmpUserName.Clear();
            textEditEmpPassword.Clear();
        }
        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idEmployee = (int)dataGridEmployee.CurrentRow.Cells[0].Value;
            textEditEmpFirstName.Text = (string)dataGridEmployee.CurrentRow.Cells[1].Value;
            textEditEmpLastName.Text = (string)dataGridEmployee.CurrentRow.Cells[2].Value;
            comboEditEmpTitle.Text = (string)dataGridEmployee.CurrentRow.Cells[3].Value;
            textEditEmpAddress.Text = (string)dataGridEmployee.CurrentRow.Cells[4].Value;
            textEditEmpPhone.Text = (string)dataGridEmployee.CurrentRow.Cells[5].Value;
            textEditEmpUserName.Text = (string)dataGridEmployee.CurrentRow.Cells[6].Value;
            textEditEmpPassword.Text = (string)dataGridEmployee.CurrentRow.Cells[7].Value;

        }
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                FirstName = textAddEmpFirstName.Text,
                LastName = textAddEmpLastName.Text,
                TitleID = (int)comboAddEmpTitle.SelectedValue,
                Address = textAddEmpAddress.Text,
                Phone = textAddEmpPhone.Text,
                UserName = textAddEmpUserName.Text,
                Password = textAddEmpPassword.Text
            };
            _employeeManager.AddEmployee(employee);
            MessageBox.Show("Employee Eklendi ");
            ListMyEmployees();
            ClearEmployeeTexts();
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = _employeeManager.GetEmployee(_idEmployee);
            employee.FirstName = textEditEmpFirstName.Text;
            employee.LastName = textEditEmpLastName.Text;
            employee.TitleID = (int)comboEditEmpTitle.SelectedValue;
            employee.Address = textEditEmpAddress.Text;
            employee.Phone = textEditEmpPhone.Text;
            employee.UserName = textEditEmpUserName.Text;
            employee.Password = textEditEmpPassword.Text;

            _employeeManager.UpdateEmployee(employee);
            MessageBox.Show("Employee guncellendi");
            ListMyEmployees();
            ClearEmployeeTexts();
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            _employeeManager.DeleteEmployee(_idEmployee);
            MessageBox.Show("Employee silindi");
            ListMyEmployees();
            ClearEmployeeTexts();
        } 
        #endregion
    }
}
