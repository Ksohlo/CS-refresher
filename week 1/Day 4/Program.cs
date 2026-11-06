
var items = new List<TaskItem>
{
  new TaskItem
  {
      Title= "Buy Book!!",
    //   Priority = Priorities.Medium,
      Status = TaskStatus.Pending
  },
  new TaskItem
  {
      Title = "Attend Swimming lessons!!",
    //   Priority = Priorities.Low,
      Status = TaskStatus.Not_Started
  }  ,
  new TaskItem
  {
      Title = "Attend Piano lessons!!",
    //   Priority = Priorities.Low,
      Status = TaskStatus.Pending
  }  
};

Dictionary<TaskStatus, int> counts = new Dictionary<TaskStatus, int>();

void GetCountByTaskStatus(Dictionary<TaskStatus, int> counts, TaskStatus status)
{
  if (counts.ContainsKey(status))
  {
    counts[status] += 1;
  }
  else
  {
    counts[status] = 1;
  }
}; 

void AddTask(List<TaskItem> list, string title, TaskStatus status)
{

    if (string.IsNullOrWhiteSpace(title))
    {
        throw new ArgumentException("Title must not be empty");
    }
    list.Add(new TaskItem{Title = title, Status = status});
 
}

try
{
    AddTask(items,"Buy Swim suit", TaskStatus.Not_Started);
    AddTask(items, "Build app", TaskStatus.Completed);
    AddTask(items, "", TaskStatus.Completed);
}
catch (ArgumentException)
{
    System.Console.WriteLine("Title cannot be empty, add a value to continue");
}


foreach (TaskItem item in items)
{
  GetCountByTaskStatus(counts, item.Status);
};

foreach (var item in Enum.GetValues<TaskStatus>())
{
    try
    {
        System.Console.WriteLine($"{item} status count is: {counts[item]}");
    }
    catch (KeyNotFoundException)
    {
        
        System.Console.WriteLine($"{item} Key not found!!");
    }

}


class TaskItem
{
    public string Title { get; set; } = "";
    public TaskStatus Status { get; set; }
    // public Priorities Priority { get; set; }
}

enum TaskStatus { Not_Started, Pending, Completed };
// enum Priorities { Low, Medium, High };