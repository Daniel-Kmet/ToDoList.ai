namespace ToDoList.Models;

public class TaskItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime? Deadline { get; set; }
    public Priority Priority { get; set; }
    public TaskItemStatus Status { get; set; } = TaskItemStatus.NotStarted;
    public Complexity? Complexity { get; set; }
    public TimeSpan? EstimatedTime { get; set; }
    public DateTime? ScheduledTime { get; set; }
}

public enum Priority
{
    Low,
    Medium,
    High,
    Urgent
}

public enum TaskItemStatus
{
    NotStarted,
    InProgress,
    Completed,
    OnHold
}

public enum Complexity
{
    Simple,
    Moderate,
    Complex
} 