using Microsoft.AspNetCore.Mvc;
using ShopAssignment.ApiIntegration.Interface;
using System.Globalization;

namespace ShopAssignment.WebApp.Controllers.Components
{
    public class NavBarViewComponent : ViewComponent
    {
        private readonly ICategoryApiClient _categoryApiClient;

        public NavBarViewComponent(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryApiClient.GetAll(CultureInfo.CurrentCulture.Name);
            return View(categories);
        }
    }
}