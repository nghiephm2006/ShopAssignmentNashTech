using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopAssignment.Application.Catalog.Order;
using ShopAssignment.ViewModels.Order;

namespace ShopAssignment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetById(int orderId)
        {
            var order = await _orderService.GetById(orderId);
            if (order == null)
                return BadRequest("Cannot find product");
            return Ok(order);
        }
        [HttpPost]
        public async Task<IActionResult> Create
            ([FromBody] CheckoutRequest request, Guid userId)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _orderService.Create(request, userId);
            if (result == 0)
                return BadRequest();
            var order = await _orderService.GetById(result);
            return CreatedAtAction(nameof(GetById), new { id = result }, order);
        }

    }
}
