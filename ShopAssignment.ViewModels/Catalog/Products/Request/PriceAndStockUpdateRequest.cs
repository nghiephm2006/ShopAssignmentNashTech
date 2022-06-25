using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAssignment.ViewModels.Catalog.Products.Request
{
    public class PriceAndStockUpdateRequest
    {
        public decimal NewPrice { set; get; }
        public int AddedQuantity { set; get; }
    }
}
