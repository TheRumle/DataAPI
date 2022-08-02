namespace Domain.ExamStress.Entities.Measurements;
//TODO Should it represented with a triple of doubles or three collections?

public class AccelerometerMeasurement : Measurement
{
    public override string Unit { get; set; } = "1/64g";
}