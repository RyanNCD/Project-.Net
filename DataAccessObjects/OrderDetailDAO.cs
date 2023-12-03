using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        public static List<OrderDetail> GetOrderDetails()
        {
            List<OrderDetail> listOrderDetails = new List<OrderDetail>();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    listOrderDetails = context.OrderDetails.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listOrderDetails;
        }
        public static void SaveOrderDetail(OrderDetail OrderDetail)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.OrderDetails.Add(OrderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteOrderDetail(OrderDetail OrderDetail)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    var od = context.OrderDetails.SingleOrDefault(m => m.OrderId == OrderDetail.OrderId 
                            && m.FlowerBouquetId == OrderDetail.FlowerBouquetId);
                    context.OrderDetails.Remove(OrderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateOrderDetail(OrderDetail OrderDetail)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    context.Entry<OrderDetail>(OrderDetail).State = EntityState.Modified;
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
