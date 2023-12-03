using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FlowerBouquetRepository : IFlowerBouquetRepository
    {
        public void DeleteFlowerBouquet(FlowerBouquet p) => FlowerBouquetDAO.DeleteFlowerBouquet(p);

        public List<FlowerBouquet> GetFlowerBouquets() => FlowerBouquetDAO.GetFlowerBouquets();

        public List<Category> GetCategories() => CategoryDAO.GetCategories();

        public FlowerBouquet GetFlowerBouquetById(int id) => FlowerBouquetDAO.GetFlowerBouquetById(id);

        public List<Supplier> GetSuppliers() => SupplierDAO.GetSuppliers();

        public void SaveFlowerBouquet(FlowerBouquet p) => FlowerBouquetDAO.SaveFlowerBouquet(p);

        public void UpdateFlowerBouquet(FlowerBouquet p) => FlowerBouquetDAO.UpdateFlowerBouquet(p);
    }
}
