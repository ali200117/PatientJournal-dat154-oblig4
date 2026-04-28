namespace SharedLibrary.Models;

public class VitalSigns
{
    public int Id { get; set; }

    public int PatientCaseId { get; set; }

    public int BloodPressure { get; set; }

    public int HeartRate { get; set; }

    public int OxygenSaturation { get; set; }

    public double Temperature { get; set; }

    public DateTime TimeStamp { get; set; }
}