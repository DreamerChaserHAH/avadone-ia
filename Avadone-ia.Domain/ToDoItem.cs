namespace Avadone_ia.Domain;

public class ToDoItem
{
    private ToDoItem() { } // Ef ctor
    public int Id { get; private set; }
    public string TaskName { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public List<ToDoItem> SubTasks { get; private set; } = [];
    public bool IsCompleted { get; private set; } = false;
    public ToDoItem(string taskName, string description, params ToDoItem[] tasks)
    {
        TaskName = taskName ?? throw new ArgumentNullException(nameof(taskName));
        Description = description ?? throw new ArgumentNullException(nameof(description));
        SubTasks = [.. tasks];
    }

}