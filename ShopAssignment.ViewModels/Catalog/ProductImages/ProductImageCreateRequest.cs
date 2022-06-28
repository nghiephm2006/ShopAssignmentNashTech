﻿using Microsoft.AspNetCore.Http;

namespace ShopAssignment.ViewModels.Catalog.Products.ProductImages
{
    public class ProductImageCreateRequest
    {
        public int ProductId { get; set; }
        public string? Caption { get; set; }

        public bool IsDefault { get; set; }

        public int SortOrder { get; set; }

        public IFormFile? ImageFile { get; set; }
    }
}