﻿namespace ShopAssignment.ViewModels.Order
{
    public class CheckoutRequest
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public List<OrderDetailViewModel> OrderDetails { set; get; } = new List<OrderDetailViewModel>();
    }
}