using Application.IntData.Common;
using AutoMapper;
using MediatR;

namespace Application.IntData.Queries.GetIntQuery;

public class GetIntQueryHandler : IRequestHandler<GetIntQuery, List<IntResponse>>{
    
    private readonly IIntRepository _repos;
    private readonly IMapper _mapper;

    public async Task<List<IntResponse>> Handle(GetIntQuery request, CancellationToken cancellationToken)
    {
        List<int> integers = await _repos.GetAllAsync();
        return _mapper.Map<List<IntResponse>>(int.MaxValue);
    }
}