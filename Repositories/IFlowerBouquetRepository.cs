using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFlowerBouquetRepository
    {
        void SaveFlowerBouquet(FlowerBouquet p);
        void DeleteFlowerBouquet(FlowerBouquet p);
        void UpdateFlowerBouquet(FlowerBouquet p);
        List<Category> GetCategories();
        List<Supplier> GetSuppliers();
        List<FlowerBouquet> GetFlowerBouquets();
        FlowerBouquet GetFlowerBouquetById(int id);
    }
}
