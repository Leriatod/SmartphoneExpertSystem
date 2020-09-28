using AutoMapper;
using PhoneExp.Controllers.Dtos;
using PhoneExp.Data.Models;

namespace PhoneExp.Mapping
{
    public class MappingProfile : Profile
    {
        // DOMAIN TO API DTO
        public MappingProfile()
        {
            CreateMap<FeatureType, FeatureTypeDto>();
        }
    }
}