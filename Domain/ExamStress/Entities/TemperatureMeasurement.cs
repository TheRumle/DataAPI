namespace Domain.ExamStress.Entities;

public class TemperatureMeasurement : Measurement
{
    public override string Unit { get; set; } = "Celsius";
}