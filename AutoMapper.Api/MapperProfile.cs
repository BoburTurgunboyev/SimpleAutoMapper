using AutoMapper.Api.Dtos;
using AutoMapper.Api.Models;

namespace AutoMapper.Api
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserDto, User>()
                .ForMember(x => x.Name, y => y.MapFrom(user => user.Firstname));
        }
    }
}
