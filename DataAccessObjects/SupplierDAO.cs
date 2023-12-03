using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SupplierDAO
    {
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> listSuppliers = new List<Supplier>();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    listSuppliers = context.Suppliers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listSuppliers;
        }
        public static Supplier GetSupplierById(int id)
        {
            Supplier Supplier = new Supplier();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    Supplier = context.Suppliers.FirstOrDefault(sup => sup.SupplierId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Supplier;
        }
        public static void SaveSupplier(Supplier Supplier)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Suppliers.Add(Supplier);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteSupplier(Supplier Supplier)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    var sup = context.Suppliers.SingleOrDefault(m => m.SupplierId == Supplier.SupplierId);
                    context.Suppliers.Remove(sup);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateSupplier(Supplier Supplier)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Entry<Supplier>(Supplier).State = EntityState.Modified;
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
