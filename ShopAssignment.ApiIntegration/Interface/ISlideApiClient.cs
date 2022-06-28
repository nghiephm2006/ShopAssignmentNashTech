using ShopAssignment.ViewModels.Utilities;

namespace ShopAssignment.ApiIntegration.Interface
{
    public interface ISlideApiClient
    {
        Task<List<SlideViewModel>> GetAll();
    }
}