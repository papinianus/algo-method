using System;
using System.Linq;

public class Program
{
    public static void Main() => Enumerable.Range(1, 3).ToList().ForEach(Console.WriteLine);
}