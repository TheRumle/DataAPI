using Domain.ExamStress.Entities.Measurements;

namespace Application.ExamStress.Handlers.Dtos;

public class StudentDataResult
{
    public string Id { get; set; }
    public ICollection<Measurement> Measurements;
}