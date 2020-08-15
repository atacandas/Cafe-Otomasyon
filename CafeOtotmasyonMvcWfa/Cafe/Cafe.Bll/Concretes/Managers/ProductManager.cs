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
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private static ProductManager _productManager;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public static ProductManager CreateSingleton(IProductDal productDal)
        {
            if (_productManager == null)
            {
                _productManager = new ProductManager(productDal);
            }

            return _productManager;
        }
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                _productDal.Add(product);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public void DeleteProduct(int id)
        {
            if (id > 0)
            {
                _productDal.Delete(new Product { ProductID = id });
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public Product GetProduct(int id)
        {
            return _productDal.Get(p => p.ProductID == id);
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetProductsByCatName();
        }

        public List<Product> GetProductsByCatId(int categoryId)
        {
            return _productDal.GetProductsByCatName(p => p.CategoryID == categoryId);
        }

        public void UpdateProduct(Product product)
        {
            if (product != null)
            {
                _productDal.Update(product);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetProductsByCatName(p => p.ProductName.Contains(productName));
        }
    }
}
