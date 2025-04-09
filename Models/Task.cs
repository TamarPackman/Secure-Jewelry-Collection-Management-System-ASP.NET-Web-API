namespace Project.Models;

public enum TaskStatus
{
    NotStarted,
    InProgress,
    Completed,
    OnHold
}

public class Task
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public TaskStatus Status { get; set; } 
}




