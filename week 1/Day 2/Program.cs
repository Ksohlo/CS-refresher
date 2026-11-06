
var tasks = new List<TaskItem>
{
    new TaskItem
    {
        Title= "Write Program",
        TaskPriority = Prioties.LOW,
        TaskStatus = Statuses.PENDING
    },
    new TaskItem
    {
        Title= "Learn C#",
        TaskPriority = Prioties.HIGH,
        TaskStatus = Statuses.PENDING
    },
    new TaskItem
    {
        Title= "Cook Food",
        TaskPriority = Prioties.MEDIUM,
        TaskStatus = Statuses.COMPLETED
    },
    new TaskItem
    {
        Title= "Eat Rice",
        TaskPriority = Prioties.MEDIUM,
        TaskStatus = Statuses.COMPLETED
    },
    new TaskItem
    {
        Title= "Launch Project",
        TaskPriority = Prioties.HIGH,
        TaskStatus = Statuses.PENDING
    },
};


// filter method 
List<TaskItem> FilterPendingHighPrioriyTasks(List<TaskItem> items)
{
    List<TaskItem> filteredList = new List<TaskItem>{};

    foreach(TaskItem t in items)
    {
        if (t.TaskStatus == Statuses.PENDING && t.TaskPriority == Prioties.HIGH)
        {
            filteredList.Add(t);
        }
    }

    return filteredList;
}

// find task by title
TaskItem? FindTaskByTitle (List<TaskItem> items, string title)
{    
    return items.FirstOrDefault(t => t.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
}

// printing method 
void PrintItem(TaskItem? item)
{       
    if (item is null)
    {
        Console.WriteLine("No items found !!!!!!");
    }
        Console.WriteLine(item?.Title);
}

List<TaskItem> result = FilterPendingHighPrioriyTasks(tasks);

TaskItem? FilteredTask = FindTaskByTitle(result, "swimming");


PrintItem(FilteredTask);

class TaskItem
{
    public string Title { get; set; } = "";
    public Prioties TaskPriority { get; set; }
    public Statuses TaskStatus { get; set; }
}

enum Prioties { HIGH, MEDIUM, LOW };
enum Statuses { PENDING, COMPLETED }