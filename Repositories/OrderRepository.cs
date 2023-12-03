using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(Order p) => OrderDAO.DeleteOrder(p);

        public List<Customer> GetCustomers() => CustomerDAO.GetCustomers();

        public Order GetOrderById(int id) => OrderDAO.GetOrderById(id);

        public List<OrderDetail> GetOrderDetails() => OrderDetailDAO.GetOrderDetails();

        public List<Order> GetOrders() => OrderDAO.GetOrders();

        public void SaveOrder(Order p) => OrderDAO.SaveOrder(p);

        public void UpdateOrder(Order p) => OrderDAO.UpdateOrder(p);
    }
}
