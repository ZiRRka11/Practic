using System; 
 
public class Counter
{
    private int value;
  
    public Counter()
    {
        value = 0;  
    }
  
    public Counter(int initial)
    {
        value = initial;  
    }
  
    public void increase()
    {
        value++;
    }
  
    public void decrease()
    {
        value--;
    }
  
    public int Value
    {
        get { return value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter counter1 = new Counter();
        Console.WriteLine("Counter 1: " + counter1.Value);
        
        Counter counter2 = new Counter(10);
        Console.WriteLine("Counter 2: " + counter2.Value);
        
        counter1.increase();
        counter2.decrease();
        
        Console.WriteLine("Counter 1: " + counter1.Value);
        Console.WriteLine("Counter 2: " + counter2.Value);
    }
}