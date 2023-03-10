using AutoMapper;
using SevenApi.Dtos;
using SevenApi.Models;

namespace SevenApi.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
     
            CreateMap<PlatformCreateDto, Platform>();
                    }
    }
}