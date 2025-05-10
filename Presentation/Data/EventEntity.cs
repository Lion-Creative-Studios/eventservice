using System.ComponentModel.DataAnnotations;

namespace Presentation.Data;

public class EventEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string? Image { get; set; }

    public string? Category { get; set; } = null!;

    public string? Status { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string? Location { get; set; } = null!;

    public string? Price { get; set; } = null!;

}
