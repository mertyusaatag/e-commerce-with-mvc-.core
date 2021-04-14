using ShopApp.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
    }
}
