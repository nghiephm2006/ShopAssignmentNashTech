using ShopAssignment.ViewModels.Paging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAssignment.ViewModels.Catalog.Products.Request
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string? Keyword { get; set; }

        public string LanguageId { get; set; }

        public int? CategoryId { get; set; }
    }
}