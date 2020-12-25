using OrdersAPI.DAL.Models;
using System.Collections.Generic;

namespace OrdersAPI.DAL.Interfaces
{
    public interface IOrdersRepository
    {
        public IEnumerable<Order> GetAllOrders();
        public Order GetOrderById(string id);
        public void AddOrder(Order order);
        public void SaveChanges();
    }
}
