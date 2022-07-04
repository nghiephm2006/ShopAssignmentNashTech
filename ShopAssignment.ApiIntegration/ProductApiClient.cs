using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using ShopAssignment.ApiIntegration.Interface;
using ShopAssignment.ViewModels.Catalog.Products;
using ShopAssignment.ViewModels.Catalog.Products.Request;
using ShopAssignment.ViewModels.Paging;
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

        public async Task<ProductViewModel> GetById(int id, string languageId)
        {
            var data = await GetAsync<ProductViewModel>($"/api/products/{id}/{languageId}");
            return data;
        }

        public async Task<List<ProductViewModel>> GetFeaturedProduct(string languageId)
        {
            var data = await GetListAsync<ProductViewModel>($"/api/products/featured/{languageId}");
            return data;
        }

        public async Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductViewModel>>(
                $"/api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}&languageId={request.LanguageId}&categoryId={request.CategoryId}");

            return data;
        }
    }
}