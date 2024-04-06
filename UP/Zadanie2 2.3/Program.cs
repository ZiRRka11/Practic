using System;

public class Worker
{
    private string Name;
    private string Surname;
    private double Rate;
    private int Days;

    public void SetName(string newName)
    {
        Name = newName;
    }

    public string GetName()
    {
        return Name;
    }

    public void SetSurname(string newSurname)
    {
        Surname = newSurname;
    }

    public string GetSurname()
    {
        return Surname;
    }

    public void SetRate(double newRate)
    {
        Rate = newRate;
    }

    public double GetRate()
    {
        return Rate;
    }

    public void SetDays(int newDays)
    {
        Days = newDays;
    }

    public int GetDays()
    {
        return Days;
    }
    public double GetSalary()
    {
        return Rate * Days;
    }
}
class Program 
{
    static void Main()
    {
        Worker worker = new Worker();
        {
            worker.SetName("Alexsander");
            worker.SetSurname("Fedorov");
            worker.SetRate(180);
            worker.SetDays(20);
        }

        Console.WriteLine($"Зарплата {worker.GetName()} {worker.GetSurname()}: {worker.GetSalary()}$");
    }
}