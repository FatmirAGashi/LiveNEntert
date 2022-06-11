using AutoMapper;
using LiveNEntert.Api.OutputModels;
using LiveNEntert.Domain;

namespace LiveNEntert.Api.Mapping
{
    public class SummaryProfile : Profile
    {
        public SummaryProfile()
        {
            CreateMap<Summary, LiveNationOutput>()
                .ForMember(dest => dest.Result, opt => opt.MapFrom(src => src.Result))
                .ForPath(dest => dest.Summary.Live, opt => opt.MapFrom(src => src.Live))
                .ForPath(dest => dest.Summary.Nation, opt => opt.MapFrom(src => src.Nation))
                .ForPath(dest => dest.Summary.LiveNation, opt => opt.MapFrom(src => src.LiveNation))
                .ForPath(dest => dest.Summary.Integer, opt => opt.MapFrom(src => src.Integer));
        }
    }
}
