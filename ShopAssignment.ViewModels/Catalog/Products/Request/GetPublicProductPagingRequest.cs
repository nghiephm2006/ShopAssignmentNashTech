using ShopAssignment.ViewModels.Paging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAssignment.ViewModels.Catalog.Products.Request
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}