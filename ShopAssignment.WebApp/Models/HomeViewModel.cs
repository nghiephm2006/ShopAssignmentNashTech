using ShopAssignment.ViewModels.Catalog.Categories;
using ShopAssignment.ViewModels.Catalog.Products;
using ShopAssignment.ViewModels.Utilities;

namespace ShopAssignment.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideViewModel> Slides { get; set; }
        public List<ProductViewModel> FeaturedProducts { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}