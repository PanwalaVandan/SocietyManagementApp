using AutoMapper;
using SocietyManagement.API.Dtos;
using SocietyManagement.API.Models;

namespace SocietyManagement.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForLoginDto>();
        }
    }
}