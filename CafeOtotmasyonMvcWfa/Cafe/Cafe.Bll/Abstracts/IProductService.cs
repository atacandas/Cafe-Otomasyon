using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Bll.Abstracts
{
    public interface IProductService
    {
        List<Product> GetProducts();
        List<Product> GetProductsByCatId(int categoryId);
        List<Product> GetProductsByProductName(string productName);
        Product GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
