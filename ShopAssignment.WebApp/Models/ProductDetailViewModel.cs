using ShopAssignment.ViewModels.Catalog.Categories;
using ShopAssignment.ViewModels.Catalog.Products;
using ShopAssignment.ViewModels.Catalog.Products.ProductImages;

namespace ShopAssignment.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryViewModel Category { get; set; }

        public ProductViewModel Product { get; set; }

        public List<ProductViewModel> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}