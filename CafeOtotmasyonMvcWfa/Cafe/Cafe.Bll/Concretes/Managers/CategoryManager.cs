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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        private static CategoryManager _categoryManager;
        
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public static CategoryManager CreateSingleton(ICategoryDal categoryDal)
        {
            if (_categoryManager == null)
            {
                _categoryManager = new CategoryManager(categoryDal);
            }

            return _categoryManager;
        }

        public void AddCategory(Category category)
        {
            if (category != null)
            {
                _categoryDal.Add(category);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public void DeleteCategory(int id)
        {
            if (id > 1)
            {
                _categoryDal.Delete(new Category { CategoryID = id });
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public Category GetCategory(int id)
        {
            return _categoryDal.Get(p => p.CategoryID == id);
        }

        public List<Category> GetCategories()
        {
            return _categoryDal.GetAll();
        }

        public void UpdateCategory(Category category)
        {
            if (category != null)
            {
                _categoryDal.Update(category);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }
    }
}
