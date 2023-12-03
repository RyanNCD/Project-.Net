using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public void DeleteCategory(Category category) => CategoryDAO.DeleteCategory(category);

        public Category GetCategoryById(int id) => CategoryDAO.GetCategoryById(id);

        public List<Category> GetCategories() => CategoryDAO.GetCategories();

        public List<FlowerBouquet> GetFlowerBouquets() => FlowerBouquetDAO.GetFlowerBouquets();

        public void SaveCategory(Category category) => CategoryDAO.SaveCategory(category);

        public void UpdateCategory(Category category) => CategoryDAO.UpdateCategory(category);
    }
}
