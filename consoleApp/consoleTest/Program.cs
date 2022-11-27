using System;

namespace consoleTest;

public record Cat(string Name, int Age)
{
    public string Name { get; set; } = Name;

    public int Age { get; set; } = Age;
}

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                Console.WriteLine(i + j);

        Console.WriteLine();
    }
}
