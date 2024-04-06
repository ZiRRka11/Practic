using System;

public class Numbers
{
    private int number1;
    private int number2;
    
    public Numbers(int num1, int num2){
        number1 = num1;
        number2 = num2;
    }
    
    public void Display(){
        Console.WriteLine("Число 1: " + number1);
        Console.WriteLine("Число 2: " + number2);
    }
    
    public void Change(int num1, int num2){
        number1 = num1;
        number2 = num2;
        Console.WriteLine("Число изменено");
    }
    
    public int Sum(){
        return number1 + number2;
    }
    
    public int Max(){
        return Math.Max(number1,number2);
    }
}

public class Program
{
    public static void Main(string[] args){
        Numbers numbers = new Numbers(5,10);
        
        Console.WriteLine("Начальные значения:");
        numbers.Display();
        
        Console.WriteLine("Измененные числа");
        numbers.Change(7, 3);
        numbers.Display();
        
        Console.WriteLine("Сумма чисел: " + numbers.Sum());
        Console.WriteLine("Наибольшее число: " + numbers.Max());
    }
}