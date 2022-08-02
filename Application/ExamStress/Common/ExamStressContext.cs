using Domain.ExamStress.Entities;
using Domain.ExamStress.Entities.Measurements;
using Microsoft.EntityFrameworkCore;

namespace Application.ExamStress.Common;

public interface IExamStressContext : IAccelerometerContext, IHeartrateContext, ITemperatureContext,
    IElectrodermalActivityContext, IPhotoplethysmographMeasurement, IStudentContext
{
}

public interface IContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
public interface IStudentContext : IContext
{
    IQueryable<Student> Students { get; }
}

public interface IPhotoplethysmographMeasurement : IContext
{
    IQueryable<PhotoplethysmographMeasurement> PhotoplethysmographMeasurements { get;  }
}

public interface IElectrodermalActivityContext : IContext
{
    IQueryable<ElectrodermalActivityMeasurement> ElectroActivities { get; }
}

public interface ITemperatureContext : IContext
{
    IQueryable<TemperatureMeasurement> Temperatures { get;  }
}

public interface IHeartrateContext : IContext
{
    IQueryable<HeartrateMeasurement> Heartrates { get; }
}

public interface IAccelerometerContext : IContext
{
    IQueryable<AccelerometerMeasurement> AccelerometerMeasurements { get; }
}