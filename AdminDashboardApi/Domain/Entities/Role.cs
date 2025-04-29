

namespace AdminDashboardApi.Domain.Entities
{
    public class Role
    {

        public Guid Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public List<Permission> Permissions { get; set; } = new();
        public ICollection<UserRole> UserRoles { get; set; } = [];
        public ICollection<RolePermission> RolePermissions { get; set; } = [];


    }


    
}
