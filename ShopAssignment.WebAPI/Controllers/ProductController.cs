using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopAssignment.Application.Catalog.Products;
using ShopAssignment.ViewModels.Catalog.Products.Request;

namespace ShopAssignment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(
            IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageProductPagingRequest request)
        {
            var products = await _productService.GetAllPaging(request);
            return Ok(products);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Test ok");
        }
    }
}
