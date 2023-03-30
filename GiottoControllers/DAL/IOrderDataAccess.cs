using GiottoControllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiottoControllers.DAL
{
    public interface IOrderDataAccess
    {
        List<OrderModel> GetAllOrder();

        void SaveOrder(OrderModel order);
    }
}
