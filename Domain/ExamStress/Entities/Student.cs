using Domain.ExamStress.Entities.Measurements;

namespace Domain.ExamStress.Entities;

public class Student //TODO mark as aggregate root
{
    public string Id { get; set; }
    public TemperatureMeasurement TemperatureMeassurement { get; set; }
    public ElectrodermalActivityMeasurement ElectrodermalActivityMeasurement { get; set; }
    public PhotoplethysmographMeasurement PhotoplethysmographMeasurement { get; set; }
    public AccelerometerMeasurement AccelerometerMeasurement { get; set; }
    public HeartrateMeasurement HeartrateMeasurement { get; set; }
}