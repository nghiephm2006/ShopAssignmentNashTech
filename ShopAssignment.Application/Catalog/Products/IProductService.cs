using ShopAssignment.ViewModels.Catalog.Products;
using ShopAssignment.ViewModels.Catalog.Products.ProductImages;
using ShopAssignment.ViewModels.Catalog.Products.Request;
using ShopAssignment.ViewModels.Paging;

namespace ShopAssignment.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<bool> UpdatePriceNStock(int productId,PriceAndStockUpdateRequest request);

        Task AddViewcount(int productId);

        Task<List<ProductViewModel>> GetAll();
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<List<ProductImageViewModel>> GetListImages(int productId);
    }
}