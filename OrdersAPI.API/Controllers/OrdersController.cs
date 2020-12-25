using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrdersAPI.API.Dtos;
using OrdersAPI.DAL.Interfaces;
using OrdersAPI.DAL.Models;

namespace OrdersAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepository ordersRepository;
        private readonly IMapper mapper;
        public OrdersController(IOrdersRepository ordersRepository, IMapper mapper)
        {
            this.ordersRepository = ordersRepository;
            this.mapper = mapper;
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
        public ActionResult<Order> GetOrderById(string id)
        {
            var orderItem = ordersRepository.GetOrderById(id);

            if (orderItem == null)
                return NotFound();

            return Ok(orderItem);
        }

        // POST api/orders
        [HttpPost]
        public ActionResult AddOrder(OrderCreateDto order)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var orderModel = mapper.Map<Order>(new Order {Dimension = order.Dimension, DropOff = order.DropOff, Pickup = order.Pickup, Status = Status.Status1 });

            ordersRepository.AddOrder(orderModel);
            ordersRepository.SaveChanges();

            return Ok(orderModel);

        }
    }
}
