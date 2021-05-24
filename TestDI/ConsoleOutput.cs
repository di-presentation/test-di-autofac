using System;
using TestDI;

public class ConsoleOutput : IOutput
{
    public void Write(string content)
    {
        Console.WriteLine(content);
    }
}
