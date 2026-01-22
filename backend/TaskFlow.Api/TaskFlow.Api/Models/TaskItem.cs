namespace TaskFlow.Api.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public bool IsCompleted { get; set; }
    }
}

