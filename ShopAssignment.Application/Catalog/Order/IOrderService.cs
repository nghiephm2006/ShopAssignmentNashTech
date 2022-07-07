using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAssignment.Data.Entities;
using ShopAssignment.ViewModels.Order;

namespace ShopAssignment.Application.Catalog.Order
{
    public interface IOrderService
    {
        Task<int> Create(CheckoutRequest request, Guid userId);
        Task<OrderViewModel> GetById (int orderId);
    }
}
