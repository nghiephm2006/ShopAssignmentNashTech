namespace ShopAssignment.ViewModels.Catalog.Products.Request
{
    public class PriceAndStockUpdateRequest
    {
        public decimal NewPrice { set; get; }
        public int AddedQuantity { set; get; }
    }
}