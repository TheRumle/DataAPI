using Application.IntData.Common;
using AutoMapper;

namespace Application.Mapping;

public class DomainToResponseProfile : Profile
{
    public DomainToResponseProfile()
    { 
        CreateMap<int, IntResponse>()
            .ForMember(
                destinationField => destinationField.getInt, 
                options => 
                    options.MapFrom(origin => int.MaxValue));
    }   
    
}

