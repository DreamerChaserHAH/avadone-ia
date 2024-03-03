namespace Avadone_ia.Domain;

//lets keep model simple with primitive types
public class ToDoItem
{
    private ToDoItem() { } // Ef ctor
    public string Description { get; private set; } = null!;
    public bool IsCompleted { get; private set; }

    public ToDoItem(string description) =>
        Description = description ?? throw new ArgumentNullException(nameof(description));

    public void MarkAsCompleted() => IsCompleted = true;
   
}

