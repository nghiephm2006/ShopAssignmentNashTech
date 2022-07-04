using ShopAssignment.ViewModels.Catalog.Categories;
using ShopAssignment.ViewModels.Catalog.Products;
using ShopAssignment.ViewModels.Paging;

namespace ShopAssignment.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }

        public PagedResult<ProductViewModel> Products { get; set; }
    }
}