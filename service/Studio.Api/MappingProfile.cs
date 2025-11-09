using AutoMapper;
using Studio.Core.Entities;
using Studio.Core.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Studio.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<AudioSample, AudioSampleDTO>().ReverseMap();

        }
    }
}
