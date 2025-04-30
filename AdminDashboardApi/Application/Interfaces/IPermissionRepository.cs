using AdminDashboardApi.Domain.Entities;

namespace AdminDashboardApi.Application.Interfaces
{
    public interface IPermissionRepository
    {
        Task<Permission?> GetByIdAsync(Guid id);
        Task<List<Permission>> GetAllAsync();
        Task AddAsync(Permission permission);
        Task UpdateAsync(Permission permission);
        Task DeleteAsync(Guid id);
    }
}
