using eShopSolution.ViewModels.Common;
using ShopAssignment.ViewModels.Paging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAssignment.ViewModels.System.Users.Request
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}