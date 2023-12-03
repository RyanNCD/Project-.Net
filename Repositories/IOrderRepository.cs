using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        void SaveOrder(Order p);
        void DeleteOrder(Order p);
        void UpdateOrder(Order p);
        List<Order> GetOrders();
        List<Customer> GetCustomers();
        List<OrderDetail> GetOrderDetails();
        Order GetOrderById(int id);
    }
}
