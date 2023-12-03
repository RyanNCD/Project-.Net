using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            List<Category> listCategories = new List<Category>();
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    listCategories = context.Categories.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listCategories;
        }

        public static Category GetCategoryById(int id)
        {
            Category Category = new Category();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    Category = context.Categories.FirstOrDefault(cus => cus.CategoryId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Category;
        }
        public static void SaveCategory(Category Category)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Categories.Add(Category);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteCategory(Category Category)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    var cus = context.Categories.SingleOrDefault(m => m.CategoryId == Category.CategoryId);
                    context.Categories.Remove(cus);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateCategory(Category Category)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Entry<Category>(Category).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
