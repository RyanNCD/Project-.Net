using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        public void DeleteSupplier(Supplier p) => SupplierDAO.DeleteSupplier(p);

        public List<FlowerBouquet> GetFlowerBouquet() => FlowerBouquetDAO.GetFlowerBouquets();

        public Supplier GetSupplierById(int id) => SupplierDAO.GetSupplierById(id);

        public List<Supplier> GetSuppliers() => SupplierDAO.GetSuppliers();

        public void SaveSupplier(Supplier p) => SupplierDAO.SaveSupplier(p);
        public void UpdateSupplier(Supplier p) => SupplierDAO.UpdateSupplier(p);
    }
}
