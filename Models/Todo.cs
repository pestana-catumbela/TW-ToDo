using System.ComponentModel.DataAnnotations;

namespace TW_ToDo.Models;

public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateOnly Deadline { get; set; }
    public DateOnly? FinishedAt { get; set; }
}