using Microsoft.AspNetCore.Identity;

namespace ShopAssignment.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}