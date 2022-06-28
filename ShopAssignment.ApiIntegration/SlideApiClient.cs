using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using ShopAssignment.ApiIntegration.Interface;
using ShopAssignment.ViewModels.Utilities;

namespace ShopAssignment.ApiIntegration
{
    public class SlideApiClient : BaseApiClient, ISlideApiClient
    {
        public SlideApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            return await GetListAsync<SlideViewModel>("/api/slides");
        }
    }
}