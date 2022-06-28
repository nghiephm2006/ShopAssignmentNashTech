using ShopAssignment.ViewModels.Utilities;

namespace ShopAssignment.Application.Utilities
{
    public interface ISlideService
    {
        Task<List<SlideViewModel>> GetAll();
    }
}