using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        void SaveOrderDetail(OrderDetail p);
        void DeleteOrderDetail(OrderDetail p);
        void UpdateOrderDetail(OrderDetail p);
        List<OrderDetail> GetOrderDetails();
    }
}
