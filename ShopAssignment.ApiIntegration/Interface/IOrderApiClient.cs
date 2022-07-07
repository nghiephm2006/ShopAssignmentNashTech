using eShopSolution.ViewModels.Common;
using ShopAssignment.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAssignment.ApiIntegration.Interface
{
    public interface IOrderApiClient
    {
        Task<ApiResult<bool>> Create(CheckoutRequest request, Guid userId);
    }
}