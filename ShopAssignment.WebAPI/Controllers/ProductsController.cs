using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopAssignment.Application.Catalog.Products;
using ShopAssignment.ViewModels.Catalog.Products.ProductImages;
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
        [Authorize]
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
            var product = await _productService.GetById(result, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new { id = result }, product);
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

        [HttpPatch("{productId}/newPriceOrStock")]
        public async Task<IActionResult> UpdatePrice(int productId, [FromBody] PriceAndStockUpdateRequest request)
        {
            var isSuccessful = await _productService.UpdatePriceNStock(productId, request);
            if (!isSuccessful)
                return BadRequest();
            return Ok();
        }

        //Images

        [HttpGet("{productId}/images")]
        public async Task<IActionResult> GetListImages(int productId)
        {
            var result = await _productService.GetListImages(productId);
            if (result == null)
                return BadRequest("Cannot find product");
            return Ok(result);
        }

        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage([FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _productService.AddImage(request);
            if (imageId == 0)
                return BadRequest();

            var image = await _productService.GetImageById(imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();

            return Ok();
        }

        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _productService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Cannot find product");
            return Ok(image);
        }
    }
}