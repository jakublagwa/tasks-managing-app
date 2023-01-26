using System;
using System.Collections.Generic;
using System.Linq;

public class TaskList
{
    private List<Task> tasks;

    public TaskList()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void RemoveTask(Task task)
    {
        tasks.Remove(task);
    }

    public void EditTask(Task task, string newName, string newDescription, Priority newPriority, DateTime newDueTime, DateTime newStartTime)
    {
        task.SetName(newName);
        task.SetDescription(newDescription);
        task.SetPriority(newPriority);
        task.SetDueDate(newDueTime);
        task.SetStartDate(newStartTime);
    }

    public List<Task> GetAllTasks()
    {
        return tasks;
    }

    //FIXME
    public List<Task> GetTasksByPriority(Priority priority)
    {
        return tasks.Where(t => t.GetPriority == priority).ToList();
    }
}