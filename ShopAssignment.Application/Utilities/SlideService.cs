using Microsoft.EntityFrameworkCore;
using ShopAssignment.Data.Context;
using ShopAssignment.ViewModels.Utilities;

namespace ShopAssignment.Application.Utilities
{
    public class SlideService : ISlideService
    {
        private readonly ShopAssignmentDBContext _context;

        public SlideService(ShopAssignmentDBContext context)
        {
            _context = context;
        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();
            return slides;
        }
    }
}