// See https://aka.ms/new-console-template for more information

// Build task
// Create a console program that stores five task titles, priorities and statuses, then prints only pending
// high-priority tasks.

var tasks = new List<TaskItem>
{
    new TaskItem
    {
        Title = "Learn C#",
        Priorities= Priorities.High,
        TaskStatus= TaskStatus.InProgress
    },
    new TaskItem
    {
        Title = "Learn Piano",
        Priorities = Priorities.Low,
        TaskStatus = TaskStatus.InProgress
    },
    new TaskItem
    {
        Title = "Launch EleVot",
        Priorities = Priorities.High,
        TaskStatus = TaskStatus.InProgress
    },
    new TaskItem
    {
        Title = "Run builds",
        Priorities = Priorities.Medium,
        TaskStatus = TaskStatus.Completed
    },
    new TaskItem
    {
        Title = "Deploy Apps",
        Priorities = Priorities.High,
        TaskStatus = TaskStatus.Completed
    }
};

foreach (var item in tasks)
{
    if (item.Priorities == Priorities.High && item.TaskStatus == TaskStatus.InProgress)
    {
        System.Console.WriteLine(item.Title);
    }
}

class TaskItem
{
    public string Title { get; set; } = "";
    public TaskStatus TaskStatus { get; set; }
    public Priorities Priorities { get; set; }
}

enum TaskStatus { InProgress, Completed };
enum Priorities { High, Medium, Low };
