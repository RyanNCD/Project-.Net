using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        public static List<Order> GetOrders()
        {
            List<Order> listOrders = new List<Order>();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    listOrders = context.Orders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listOrders;
        }
        public static Order GetOrderById(int id)
        {
            Order Order = new Order();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    Order = context.Orders.FirstOrDefault(cus => cus.OrderId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Order;
        }
        public static void SaveOrder(Order Order)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Orders.Add(Order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteOrder(Order Order)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    var order = context.Orders.SingleOrDefault(m => m.OrderId == Order.OrderId);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateOrder(Order Order)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Entry<Order>(Order).State = EntityState.Modified;
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
