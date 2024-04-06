using System;

public class Worker
{
    public string Name {get; set;}
    public string Surname {get; set;}
    public double Rate {get; set;}
    public int Days {get; set;}

    public double GetSalary()
    {
        return Rate * Days;
    }
}
class Program 
{
    static void Main()
    {
        Worker worker = new Worker
        {
            Name = "Alexsander",
            Surname = "Fedorov",
            Rate = 180,
            Days = 20
        };

        Console.WriteLine($"Зарплата {worker.Name} {worker.Surname}: {worker.GetSalary()}$");
    }
}