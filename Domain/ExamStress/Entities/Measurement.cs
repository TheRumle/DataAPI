namespace Domain.ExamStress.Entities;

public abstract class Measurement
{
    public abstract string Unit { get; set; }
    public DateTime MeasurementStartTime { get; set; }
    public ICollection<double> Measurements { get; set; }
}