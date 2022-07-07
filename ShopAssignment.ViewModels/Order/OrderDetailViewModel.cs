using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAssignment.ViewModels.Order
{
    public class OrderDetailViewModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal Price { set; get; }
    }
}