

List<TaskItem> tasks = new List<TaskItem>{
    new TaskItem
    {
        Title= "Go and swim",
        Priority = TaskPriority.Low,
        Status = TaskStatus.Pending
    },
    new TaskItem
    {
        Title = "Launch Ship",
        Priority =TaskPriority.High,
        Status = TaskStatus.Pending
    }
};

async Task<List<TaskItem>> GetTasksAsync(List<TaskItem> item, CancellationToken canTok)
{
    await Task.Delay(300);
    // canTok
    return item;
}

var result = await GetTasksAsync(tasks);

foreach (TaskItem t in result)
{
    System.Console.WriteLine(t.Title);
}

class TaskItem {
    public string Title { get; set; } = "";
    public TaskStatus Status { get; set; }
    public TaskPriority Priority { get; set; }
}

enum TaskStatus { Pending, Finished };
enum TaskPriority { Low, Medium, High };