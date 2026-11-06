
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

void getCountByTaskStatus(Dictionary<TaskStatus, int> counts, TaskStatus status)
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

foreach (TaskItem item in items)
{
  getCountByTaskStatus(counts, item.Status);
};

foreach (var item in Enum.GetValues<TaskStatus>())
{
  System.Console.WriteLine($"{item} status count is: {(counts.GetValueOrDefault(item))}");
}


class TaskItem
{
    public string Title { get; set; } = "";
    public TaskStatus Status { get; set; }
    // public Priorities Priority { get; set; }
}

enum TaskStatus { Not_Started, Pending, Completed };
// enum Priorities { Low, Medium, High };