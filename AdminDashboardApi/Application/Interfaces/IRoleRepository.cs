using AdminDashboardApi.Domain.Entities;

namespace AdminDashboardApi.Application.Interfaces
{
    public interface IRoleRepository
    {
        Task<Role?> GetByIdAsync(Guid id);
        Task<List<Role>> GetAllAsync();
        Task AddAsync(Role role);
        Task UpdateAsync(Role role);
        Task DeleteAsync(Guid id);
    }
}
