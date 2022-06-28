using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using ShopAssignment.ApiIntegration.Interface;
using ShopAssignment.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAssignment.ApiIntegration
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        public ProductApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<ProductViewModel>> GetFeaturedProduct(string languageId)
        {
            var data = await GetListAsync<ProductViewModel>($"/api/products/featured/{languageId}");
            return data;
        }
    }
}