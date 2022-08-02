namespace Domain.ExamStress.Entities;

public class Student
{
    public TemperatureMeasurement TemperatureMeassurement { get; set; }
    public ElectrodermalActivityMeasurement ElectrodermalActivityMeasurement { get; set; }
    public PhotoplethysmographMeasurement PhotoplethysmographMeasurement { get; set; }
    public AccelerometerMeasurement AccelerometerMeasurement { get; set; }
    public HeartrateMeasurement HeartrateMeasurement { get; set; }
}