using ShopAssignment.ViewModels.Catalog.Products;
using ShopAssignment.ViewModels.Catalog.Products.Request;
using ShopAssignment.ViewModels.Paging;

namespace ShopAssignment.ApiIntegration.Interface
{
    public interface IProductApiClient
    {
        Task<List<ProductViewModel>> GetFeaturedProduct(string languageId);

        Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);

        Task<ProductViewModel> GetById(int id, string languageId);
    }
}