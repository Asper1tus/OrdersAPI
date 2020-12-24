using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrdersAPI.DAL.Interfaces;
using OrdersAPI.DAL.Models;

namespace OrdersAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepository ordersRepository;
        public OrdersController(IOrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;
        }

        // GET api/orders/
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAllOrders()
        {
            var orderItems = ordersRepository.GetAllOrders();
            return Ok(orderItems);
        }

        // GET api/orders/{id}
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            var orderItem = ordersRepository.GetOrderById(id);
            return Ok(orderItem);
        }

        // POST api/orders
        [HttpPost]
        public ActionResult AddOrder(Order order)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            ordersRepository.AddOrder(order);
            return Ok(order);

        }
    }
}
