using Microsoft.AspNetCore.Identity;
using OnlineEdu.Entity.Entities;
using OnlineEdu.WebUI_.DTOs.UserDtos;

namespace OnlineEdu.WebUI_.Services.UserServices
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsnyc(UserRegisterDto userRegisterDto);
        Task<string> LoginAsync(UserLoginDto userLoginDto);
        Task<bool> LogoutAsync();
        Task<bool> CreateRoleAsync(UserRoleDto userRoleDto);
        Task<bool> AssignRoleAsync(List<AssignRoleDto> assignRoleDto);
        Task<List<AppUser>> GetAllUserAsync();
        Task<AppUser> GetUserByIdAsync(int id);
    }
}
