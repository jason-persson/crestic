namespace Db;

public class Run
{
    public int Id { get; set; }

    public DateTime StartTimeUtc { get; set; }
    public DateTime EndTimeUtc { get; set; }
    public int ResticExitCode { get; set; }

    public ICollection<Log> Logs { get; set; } = new List<Log>();
}