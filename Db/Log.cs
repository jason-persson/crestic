using System.ComponentModel.DataAnnotations;

namespace Db;

public class Log
{
    public int Id { get; set; }

    public DateTime TimeUtc { get; set; }

    [MaxLength(2048)] public string Message { get; set; } = null!;

    public int RunId { get; set; }
    public Run Run { get; set; } = null!;
}