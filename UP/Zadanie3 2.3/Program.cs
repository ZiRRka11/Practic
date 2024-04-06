using System;

public class Calculation
{
    public string calculationLine { get; private set; }

    public void SetCalculationLine(string newLine)
    {
        calculationLine = newLine;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        if (String.IsNullOrEmpty(calculationLine))
        {
            return;
        }
        return calculationLine[calculationLine.Length - 1];
    }

    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        
    }
}