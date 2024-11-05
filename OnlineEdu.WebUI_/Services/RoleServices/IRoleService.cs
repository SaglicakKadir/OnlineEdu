using OnlineEdu.WebUI_.DTOs.RoleDtos;

namespace OnlineEdu.WebUI_.Services.RoleServices
{
    public interface IRoleService
    {
        Task<List<ResultRoleDto>> GetAllRolesAsync();
        Task<UpdateRoleDto> GetroleByIdAsync(int id);
        Task CreateRoleAsync(CreateRoleDto createRoleDto);
        Task DeleteRoleAsync(int id);
    }
}
