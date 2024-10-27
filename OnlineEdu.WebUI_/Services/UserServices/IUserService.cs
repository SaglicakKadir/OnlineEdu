using Microsoft.AspNetCore.Identity;
using OnlineEdu.WebUI_.DTOs.UserDtos;

namespace OnlineEdu.WebUI_.Services.UserServices
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsnyc(UserRegisterDto userRegisterDto);
        Task<bool> LoginAsync(UserLoginDto userLoginDto);
        Task<bool> LogoutAsync();
        Task<bool> CreateRoleAsync(UserRoleDto userRoleDto);
        Task<bool> AssignRoleAsync(AssignRoleDto assignRoleDto);
    }
}
