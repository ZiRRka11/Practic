using System;

public class Property
{
    public int property1 { get; set; }
    public string property2 { get; set; }

    public Property(int value1, string value2)
    {
        property1 = value1;
        property2 = value2;
    }

    public Property()
    {
        property1 = 0;
        property2 = "По умолчанию";
    }

    ~Property()
    {
        Console.WriteLine("Объект был удалён");
    }
}

class Program
{
    static void Main()
    {
        Property object1 = new Property(10, "Привет");
        
        Console.WriteLine($"Объект 1 properties: {object1.property1}, property2: {object1.property2}");

        Property object2 = new Property();
     
        Console.WriteLine($"Объект 2 - properties: {object2.property1}, property2: {object2.property2}");

        object1 = null;
        object2 = null;
        GC.Collect();
    }
    
}