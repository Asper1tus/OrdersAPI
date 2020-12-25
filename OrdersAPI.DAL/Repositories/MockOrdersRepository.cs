using OrdersAPI.DAL.Interfaces;
using OrdersAPI.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrdersAPI.DAL.Repositories
{
    public class MockOrdersRepository : IOrdersRepository
    {
        private List<Order> orders;
        private int counter = 3;
        
        public MockOrdersRepository()
        {
            orders = new List<Order>
            {
                new Order{Id = "0", Status = Status.Status1, Dimension = "Dimension1", DropOff = new Location(){ Latitude = 1, Longitude = 1 }, Pickup = new Location(){ Latitude = 1, Longitude = 1} },
                new Order{Id = "1", Status = Status.Status2, Dimension = "Dimension2", DropOff = new Location(){ Latitude = 2, Longitude = 2 }, Pickup = new Location(){ Latitude = 2, Longitude = 2} },
                new Order{Id = "2", Status = Status.Status3, Dimension = "Dimension3", DropOff = new Location(){ Latitude = 3, Longitude = 3 }, Pickup = new Location(){ Latitude = 3, Longitude = 3} },
            };
        }
        public void AddOrder(Order order)
        {
            order.Id = counter.ToString();
            counter++;

            orders.Add(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }

        public Order GetOrderById(string id)
        {
            return orders.FirstOrDefault(x => x.Id == id);
        }

        public void SaveChanges()
        {
            return;
        }
    }
}
