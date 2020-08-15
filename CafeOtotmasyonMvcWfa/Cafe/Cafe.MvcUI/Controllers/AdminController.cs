using Cafe.Bll.Abstracts;
using Cafe.Bll.Concretes.Managers;
using Cafe.Dal.Concretes.EntityFramework;
using Cafe.Entity.Concretes;
using Cafe.MvcUI.Attributes.AuthorizeAttributes;
using Cafe.MvcUI.Models.ViewModels.ListViewModels;
using Cafe.MvcUI.Models.ViewModels.ManipulationViewModels;
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
    public class AdminController : Controller
    {
        IProductService _productManager = ProductManager.CreateSingleton(new EfProductDal());
        ICategoryService _categoryManager = CategoryManager.CreateSingleton(new EfCategoryDal());
        IEmployeeService _employeeManager = EmployeeManager.CreateSingleton(new EfEmployeeDal());
        ITitleService _titleManager = TitleManager.CreateSingleton(new EfTitleDal());

        #region Product
        [HttpGet]
        public ActionResult ProductManiPage(int sayfa=1)
        {
            var products = _productManager.GetProducts().ToPagedList(sayfa, 10);
            return View(products);
        }

        [HttpGet]
        public ActionResult AddNewProduct()
        {
            ManiProductsViewModel model = new ManiProductsViewModel()
            {
                Product = new Product(),
                Categories = _categoryManager.GetCategories(),
                ButtonName = "Add Product"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult AddNewProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                ManiProductsViewModel model = new ManiProductsViewModel
                {
                    Product = new Product(),
                    Categories = _categoryManager.GetCategories(),
                    ButtonName = "Add Product"
                };
                return View(model);
            }
            _productManager.AddProduct(product);
            TempData["message"] = "Yeni ürün eklendi";
            return RedirectToAction("ProductManiPage");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            ManiProductsViewModel model = new ManiProductsViewModel()
            {
                Product = _productManager.GetProduct(id),
                Categories = _categoryManager.GetCategories(),
                ButtonName = "Update Product",
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                ManiProductsViewModel model = new ManiProductsViewModel
                {
                    Product = _productManager.GetProduct(product.ProductID),
                    Categories = _categoryManager.GetCategories(),
                    ButtonName = "Update Product",
                };
                return View(model);
            }
            _productManager.UpdateProduct(product);
            TempData["message"] = "Ürün Güncellendi";
            return RedirectToAction("ProductManiPage");
        }
        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            _productManager.DeleteProduct(id);
            TempData["message"] = "Ürün silindi";
            return RedirectToAction("ProductManiPage");
        }
        #endregion

        #region Category
        [HttpGet]
        public ActionResult CategoryManiPage()
        {
            ListCategoriesViewModel model = new ListCategoriesViewModel
            {
                Categories = _categoryManager.GetCategories()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddNewCategory()
        {
            ManiCategoriesViewModel model = new ManiCategoriesViewModel()
            {
                Category = new Category(),
                ButtonName = "Add Category"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult AddNewCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                ManiCategoriesViewModel model = new ManiCategoriesViewModel
                {
                    Category = new Category(),
                    ButtonName = "Add Category"
                };
                return View(model);
            }
            _categoryManager.AddCategory(category);
            TempData["message"] = "Yeni kategori eklendi";
            return RedirectToAction("CategoryManiPage");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            ManiCategoriesViewModel model = new ManiCategoriesViewModel()
            {
                Category = _categoryManager.GetCategory(id),
                ButtonName = "Update Category",
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                ManiCategoriesViewModel model = new ManiCategoriesViewModel()
                {
                    Category = _categoryManager.GetCategory(category.CategoryID),
                    ButtonName = "Update Category",
                };
                return View(model);
            }
            _categoryManager.UpdateCategory(category);
            TempData["message"] = "Kategori Güncellendi";
            return RedirectToAction("CategoryManiPage");
        }
        [HttpGet]
        public ActionResult DeleteCategory(int id)
        {
            _categoryManager.DeleteCategory(id);
            TempData["message"] = "Kategori silindi";
            return RedirectToAction("CategoryManiPage");
        }
        #endregion

        #region Employee
        [HttpGet]
        public ActionResult EmployeeManiPage()
        {
            ListEmployeesViewModel model = new ListEmployeesViewModel
            {
                Employees = _employeeManager.GetEmployees()

            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddNewEmployee()
        {
            ManiEmployeesViewModel model = new ManiEmployeesViewModel()
            {
                Employee = new Employee(),
                Titles = _titleManager.GetTitles(),
                ButtonName = "Add Employee",
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult AddNewEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                ManiEmployeesViewModel model = new ManiEmployeesViewModel()
                {
                    Employee = new Employee(),
                    Titles = _titleManager.GetTitles(),
                    ButtonName = "Add Employee",
                };
                return View(model);
            }
            _employeeManager.AddEmployee(employee);
            TempData["message"] = "Yeni çalışan eklendi";
            return RedirectToAction("EmployeeManiPage");
        }
        [HttpGet]
        public ActionResult UpdateEmployee(int id)
        {
            ManiEmployeesViewModel model = new ManiEmployeesViewModel()
            {
                Employee = _employeeManager.GetEmployee(id),
                Titles = _titleManager.GetTitles(),
                ButtonName = "Update Employee",
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                ManiEmployeesViewModel model = new ManiEmployeesViewModel()
                {
                    Employee = _employeeManager.GetEmployee(employee.EmployeeID),
                    Titles = _titleManager.GetTitles(),
                    ButtonName = "Update Employee",
                };
                return View(model);
            }
            _employeeManager.UpdateEmployee(employee);
            TempData["message"] = "Çalışan Güncellendi";
            return RedirectToAction("EmployeeManiPage");
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int id)
        {
            _employeeManager.DeleteEmployee(id);
            TempData["message"] = "Çalışan silindi";
            return RedirectToAction("EmployeeManiPage");
        }
        #endregion

        #region Title
        [HttpGet]
        public ActionResult TitleManiPage()
        {
            ListTitlesViewModel model = new ListTitlesViewModel
            {
                Titles = _titleManager.GetTitles()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddNewTitle()
        {
            ManiTitleViewModel model = new ManiTitleViewModel()
            {
                Title = new Title(),
                ButtonName = "Add Title"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult AddNewTitle(Title title)
        {
            if (!ModelState.IsValid)
            {
                ManiTitleViewModel model = new ManiTitleViewModel()
                {
                    Title = new Title(),
                    ButtonName = "Add Title"
                };
                return View(model);
            }
            _titleManager.AddTitle(title);
            TempData["message"] = "Yeni ünvan eklendi";
            return RedirectToAction("TitleManiPage");
        }
        [HttpGet]
        public ActionResult UpdateTitle(int id)
        {
            ManiTitleViewModel model = new ManiTitleViewModel()
            {
                Title = _titleManager.GetTitle(id),
                ButtonName = "Update Title",
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateTitle(Title title)
        {
            if (!ModelState.IsValid)
            {
                ManiTitleViewModel model = new ManiTitleViewModel()
                {
                    Title = _titleManager.GetTitle(title.TitleID),
                    ButtonName = "Update Title",
                };
                return View(model);
            }
            _titleManager.UpdateTitle(title);
            TempData["message"] = "Ünvan Güncellendi";
            return RedirectToAction("TitleManiPage");
        }
        [HttpGet]
        public ActionResult DeleteTitle(int id)
        {
            _titleManager.DeleteTitle(id);
            TempData["message"] = "Ünvan silindi";
            return RedirectToAction("TitleManiPage");
        } 
        #endregion
    }
}