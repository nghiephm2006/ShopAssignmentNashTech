using Microsoft.AspNetCore.Mvc;
using ShopAssignment.Application.Catalog.Products;
using ShopAssignment.ViewModels.Catalog.Products.Request;

namespace ShopAssignment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(
            IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet] 
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageProductPagingRequest request)
        {
            var products = await _productService.GetAllPaging(request);
            return Ok(products);
        }

        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var product = await _productService.GetById(productId, languageId);
            if (product == null)
                return BadRequest("Cannot find product");
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create
            ([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.Create(request);
            if (result == 0)
                return BadRequest();
            var product = await _productService.GetById(result,request.LanguageId);
            return CreatedAtAction(nameof(GetById), new {id = result }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update
            ([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.Update(request);
            if (result == 0)
                return BadRequest();
            return Ok(result);
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete
            (int productId)
        {
            var result = await _productService.Delete(productId);
            if (result == 0)
                return BadRequest();
            return Ok(result);
        }

        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccessful = await _productService.UpdatePrice(productId, newPrice);
            if (!isSuccessful)
                return BadRequest();
            return Ok();
        }

        [HttpPatch("{productId}/{addedStock}")]
        public async Task<IActionResult> UpdateStock(int productId, decimal addedStock)
        {
            var isSuccessful = await _productService.UpdatePrice(productId, addedStock);
            if (!isSuccessful)
                return BadRequest();
            return Ok();
        }



    }
}
