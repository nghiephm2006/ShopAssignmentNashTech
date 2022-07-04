using Microsoft.AspNetCore.Mvc;
using ShopAssignment.ViewModels.Paging;

namespace ShopAssignment.WebApp.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}