using System.Linq;
using AutoMapper;
using PhoneExp.Controllers.Dtos;
using PhoneExp.Data.Models;

namespace PhoneExp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // DOMAIN TO API DTO
            CreateMap<FeatureType, FeatureTypeDto>();
            CreateMap<Feature, FeatureDto>();
            CreateMap<Phone, PhoneDto>()
                .ForMember(pdto => pdto.FeaturesIds, opt => opt.MapFrom(p => p.Features.Select(pf => pf.FeatureId)));
        }
    }
}