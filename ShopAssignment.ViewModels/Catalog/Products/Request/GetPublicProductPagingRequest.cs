using ShopAssignment.ViewModels.Paging;

namespace ShopAssignment.ViewModels.Catalog.Products.Request
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}