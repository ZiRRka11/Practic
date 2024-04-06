using System;
class HelloWorld {
    public static int Jewels(string j,string s)
    {
        int jewel = 0;
        foreach(char stone in s)
        {
            if(j.Contains(stone))
            {
                jewel++;
            }
        }
        return jewel;
    }
    public static void Main()
    {
        string j = "ab";
        string s = "aabbccd";
        Console.WriteLine(Jewels(j, s));
    }
}