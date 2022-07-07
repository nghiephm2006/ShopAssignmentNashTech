using ShopAssignment.Data.Context;
using ShopAssignment.Data.Entities;
using ShopAssignment.ViewModels.Order;

namespace ShopAssignment.Application.Catalog.Order
{
    public class OrderService : IOrderService
    {
        private readonly ShopAssignmentDBContext _context;
        public OrderService(ShopAssignmentDBContext context)
        {
            _context = context;
        }

        public async Task<int> Create(CheckoutRequest request,Guid userId)
        {
            var order = new Data.Entities.Order()
            {
                OrderDate = DateTime.UtcNow,
                UserId = userId,
                CustomerName = request.Name,
                CustomerAddress = request.Address,
                CustomerEmail = request.Email,
                CustomerPhoneNumber = request.PhoneNumber,
                Status = Data.Enums.OrderStatus.Success

            };
            _context.Add(order);
            await _context.SaveChangesAsync();
            var orderId = order.Id;
            var orderDetail = request.OrderDetails;
            if(orderDetail != null)
            {
                foreach ( var item in orderDetail )
                {
                    item.OrderId = orderId;
                    _context.Add(orderDetail);
                }
            }
            return orderId;
        }

        public async Task<OrderViewModel> GetById(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            var orderViewModel = new OrderViewModel()
            {
                Id = order.Id,
                CustomerName = order.CustomerName,
                CustomerAddress = order.CustomerAddress,
                CustomerEmail = order.CustomerEmail,
                Status = (int)order.Status
            };
            return orderViewModel;
        }
    }
}
