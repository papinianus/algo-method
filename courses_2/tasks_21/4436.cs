using System;
using System.Linq;

public class Program
{
    public static void Main() =>
        Console.WriteLine(string.Concat(Enumerable.Repeat(Console.ReadLine(), 3)));
}