using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> listCustomers = new List<Customer>();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    listCustomers = context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listCustomers;
        }
        public static Customer GetCustomerById(int id)
        {
            Customer Customer = new Customer();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    Customer = context.Customers.FirstOrDefault(cus => cus.CustomerId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Customer;
        }
        public static Customer GetCustomerByEmail(string email)
        {
            Customer Customer = new Customer();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    Customer = context.Customers.FirstOrDefault(cus => cus.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Customer;
        }
        public static void SaveCustomer(Customer Customer)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Customers.Add(Customer);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteCustomer(Customer Customer)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    var cus = context.Customers.SingleOrDefault(m => m.CustomerId == Customer.CustomerId);
                    context.Customers.Remove(cus);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateCustomer(Customer Customer)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Entry<Customer>(Customer).State = EntityState.Modified;
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
