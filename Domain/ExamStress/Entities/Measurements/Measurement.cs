namespace Domain.ExamStress.Entities.Measurements;

public abstract class Measurement //TODO aggregate root
{
    public abstract string Unit { get; set; }
    public DateTime MeasurementStartTime { get; set; }
    public ICollection<double> Measurements { get; set; }
}