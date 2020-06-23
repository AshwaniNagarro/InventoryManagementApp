using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderAPI.Models;

namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private static readonly Order[] _orders = new Order[]
        {
            new Order{ OrderId =1 , OrderAmount = 1000, OrderDate = "01-Jul-2020" },
           new Order{ OrderId =2 , OrderAmount = 2000, OrderDate = "15-Jul-2020" }
        };

        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return _orders.AsEnumerable();
        }

        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orders.SingleOrDefault(x=>x.OrderId == id);
        }
    }
}
