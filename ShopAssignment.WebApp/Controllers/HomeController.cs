using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using ShopAssignment.ApiIntegration.Interface;
using ShopAssignment.WebApp.Models;
using System.Diagnostics;
using System.Globalization;

namespace ShopAssignment.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISlideApiClient _slideApiClient;
        private readonly IProductApiClient _prodctApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public HomeController(ILogger<HomeController> logger, ISlideApiClient slideApiClient,
            IProductApiClient productApiClient,
            ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
            _prodctApiClient = productApiClient;
            _slideApiClient = slideApiClient;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var culture = CultureInfo.CurrentCulture.Name;
            var viewModel = new HomeViewModel
            {
                Slides = await _slideApiClient.GetAll(),
                FeaturedProducts = await _prodctApiClient.GetFeaturedProduct(culture),
                Categories = await _categoryApiClient.GetAll(culture)
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }
    }
}