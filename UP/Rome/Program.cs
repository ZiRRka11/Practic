using System;
using System.Collections.Generic;

public class Rome
{
    public int Roman(string s)
    {
        Dictionary<char, int> RomeDict = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        int result = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && RomeDict[s[i]] < RomeDict[s[i + 1]])
            {
                result -= RomeDict[s[i]];
            }
            else
            {
                result += RomeDict[s[i]];
            }
        }
        return result;
    }
}

public class Program
{
    
   public static void Main()
    {
        Rome rome  = new Rome();
        Console.WriteLine("Введите число: ");
        string input = Console.ReadLine(); 
        int result = rome.Roman(input);
        Console.WriteLine(result);

    }
    
}
