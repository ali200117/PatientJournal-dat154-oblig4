namespace SharedLibrary.Models;

public class Intervention
{
    public int Id { get; set; }

    public int PatientCaseId { get; set; }

    public string Type { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime TimeStamp { get; set; }
}