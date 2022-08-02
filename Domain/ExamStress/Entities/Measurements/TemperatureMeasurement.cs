namespace Domain.ExamStress.Entities.Measurements;

public class TemperatureMeasurement : Measurement
{
    public override string Unit { get; set; } = "Celsius";
}