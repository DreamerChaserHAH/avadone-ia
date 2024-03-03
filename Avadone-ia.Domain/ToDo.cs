namespace Avadone_ia.Domain;

public class ToDo
{
    private ToDo() { } // Ef ctor
    public string TaskName { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public List<ToDoItem> SubTasks { get; private set; } = [];
    public bool IsCompleted => SubTasks.All(task => task.IsCompleted);
    public ToDo(string taskName, string description, params ToDoItem[] tasks)
    {
        TaskName = taskName ?? throw new ArgumentNullException(nameof(taskName));
        Description = description ?? throw new ArgumentNullException(nameof(description));
        SubTasks = [.. tasks];
    }

}