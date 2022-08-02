using System.Diagnostics.Metrics;
using Application.ExamStress.Common;
using Application.ExamStress.Handlers.Dtos;
using Application.ExamStress.Queries;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.ExamStress.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.ExamStress.Handlers;

public class GetExamStressQueryHandler : IRequestHandler<GetStudentDataQuery, List<StudentDataResult>>
{
    private readonly IStudentContext _context;
    private readonly IMapper _mapper;

    public GetExamStressQueryHandler(IStudentContext context, IMapper mapper)
    {
        _context = context;
         _mapper = mapper;
    }
    

    public async Task<List<StudentDataResult>> Handle(GetStudentDataQuery request, CancellationToken cancellationToken)
    {
        //TODO from the request, get all the data and filter directly on the context.
        IQueryable<StudentDataResult>? query = _context.Students.AsNoTracking().Where(
            student => request.FilterModel != null && request.FilterModel.Id == student.Id)
            .ProjectTo<StudentDataResult>(_mapper.ConfigurationProvider);

        return await query.ToListAsync(cancellationToken: cancellationToken);
    }
}