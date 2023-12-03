using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class FlowerBouquetDAO
    {   
        public static List<FlowerBouquet> GetFlowerBouquets()
        {
            List<FlowerBouquet> listFlowerBouquets = new List<FlowerBouquet>();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    listFlowerBouquets = context.FlowerBouquets.Include(fb => fb.Category).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listFlowerBouquets;
        }
        public static FlowerBouquet GetFlowerBouquetById(int id)
        {
            FlowerBouquet FlowerBouquet = new FlowerBouquet();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    FlowerBouquet = context.FlowerBouquets.FirstOrDefault(cus => cus.FlowerBouquetId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return FlowerBouquet;
        }
        public static void SaveFlowerBouquet(FlowerBouquet FlowerBouquet)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.FlowerBouquets.Add(FlowerBouquet);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteFlowerBouquet(FlowerBouquet FlowerBouquet)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    var fb = context.FlowerBouquets.SingleOrDefault(m => m.FlowerBouquetId == FlowerBouquet.FlowerBouquetId);
                    context.FlowerBouquets.Remove(fb);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateFlowerBouquet(FlowerBouquet FlowerBouquet)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Entry<FlowerBouquet>(FlowerBouquet).State = EntityState.Modified;
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
