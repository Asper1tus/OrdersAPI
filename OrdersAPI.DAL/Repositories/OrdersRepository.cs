using OrdersAPI.DAL.Interfaces;
using OrdersAPI.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrdersAPI.DAL.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly ApplicationContext context;

        public OrdersRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public void AddOrder(Order order)
        {
            context.Orders.Add(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return context.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return context.Orders.FirstOrDefault(p => p.Id == id);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
