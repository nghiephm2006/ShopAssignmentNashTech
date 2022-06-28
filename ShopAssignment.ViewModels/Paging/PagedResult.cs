namespace ShopAssignment.ViewModels.Paging
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}