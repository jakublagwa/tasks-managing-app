using System;

public class Task
{
    private string name;
    private string description;
    private DateTime startDate;
    private DateTime dueDate;
    private bool isCompleted;
    private Priority priority;

    public void SetName(string name)
    {
        this.name = name;
    }
    
    public void SetDescription(string description)
    {
        this.description = description;
    }

    public void SetStartDate(DateTime startDate)
    {
        this.startDate = startDate;
    }

    public void SetDueDate(DateTime dueDate)
    {
        this.dueDate = dueDate;
    }

    public void Complete()
    {
        this.isCompleted = true;
    }

    public void SetPriority(Priority priority)
    {
        this.priority = priority;  
    }
    public bool IsCompleted()
    {
        return this.isCompleted;
    }

    public string GetName()
    {
        return this.name;
    }

    public string GetDescription()
    {
        return this.description;
    }

    public DateTime GetDueDate()
    {
        return this.dueDate;
    }

    public DateTime GetStartDate()
    {
        return this.startDate;
    }

    public Priority GetPriority()
    {
        return priority;
    }
}   