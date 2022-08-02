using Application.ExamStress.Common;
using Domain.ExamStress.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class StudentContext : IStudentContext
{
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Student> Students { get => throw new NotImplementedException(); }
}