using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAssignment.ViewModels.Paging
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}