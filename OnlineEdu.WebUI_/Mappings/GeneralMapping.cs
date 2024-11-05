using AutoMapper;
using OnlineEdu.Entity.Entities;
using OnlineEdu.WebUI_.DTOs.RoleDtos;

namespace OnlineEdu.WebUI_.Mappings
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<AppRole,ResultRoleDto>().ReverseMap();
            CreateMap<AppRole,CreateRoleDto>().ReverseMap();
            CreateMap<AppRole,UpdateRoleDto>().ReverseMap();
        }
    }
}
