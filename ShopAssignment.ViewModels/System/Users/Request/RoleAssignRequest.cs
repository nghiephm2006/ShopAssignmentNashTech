using ShopAssignment.ViewModels.Common;

namespace ShopAssignment.ViewModels.System.Users.Request
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}