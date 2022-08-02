using Application.ExamStress.Handlers;
using Application.ExamStress.Handlers.Dtos;
using Domain.ExamStress.Entities;
using MediatR;

namespace Application.ExamStress.Queries;

public class GetStudentDataQuery : IRequest<List<StudentDataResult>>
{
    public Student? FilterModel { get; set; }
}
