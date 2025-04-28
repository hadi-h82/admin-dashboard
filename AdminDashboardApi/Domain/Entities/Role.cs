

namespace AdminDashboardApi.Domain.Entities
{
    public class Role
    {

        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public List<Permission> Permissions { get; set; } = new();


    }


    
}
