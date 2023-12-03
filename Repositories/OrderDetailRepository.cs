using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(OrderDetail p) => OrderDetailDAO.DeleteOrderDetail(p);

        public List<OrderDetail> GetOrderDetails() => OrderDetailDAO.GetOrderDetails();

        public void SaveOrderDetail(OrderDetail p) => OrderDetailDAO.SaveOrderDetail(p);
        public void UpdateOrderDetail(OrderDetail p) => OrderDetailDAO.UpdateOrderDetail(p);
    }
}
