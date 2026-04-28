namespace SharedLibrary.Models;

public class TimelineEvent
{
    public int Id { get; set; }

    public int PatientCaseId { get; set; }

    public string Text { get; set; } = string.Empty;

    public DateTime TimeStamp { get; set; }
}