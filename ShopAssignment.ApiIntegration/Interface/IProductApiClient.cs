using ShopAssignment.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAssignment.ApiIntegration.Interface
{
    public interface IProductApiClient
    {
        Task<List<ProductViewModel>> GetFeaturedProduct(string languageId);
    }
}