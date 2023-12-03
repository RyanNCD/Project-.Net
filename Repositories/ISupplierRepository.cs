using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISupplierRepository
    {
        void SaveSupplier(Supplier p);
        void DeleteSupplier(Supplier p);
        void UpdateSupplier(Supplier p);
        List<Supplier> GetSuppliers();
        Supplier GetSupplierById(int id);
        List<FlowerBouquet> GetFlowerBouquet();
    }
}
