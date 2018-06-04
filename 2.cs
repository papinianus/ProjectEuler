using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Fibonacci().TakeWhile(x => x < 4000000).Where(x => x % 2 == 0).Sum());
    }

    private static IEnumerable<int> Fibonacci()
    {
        int current = 1, next = 1;

        while (true)
        {
            yield return current;
            next = current + (current = next);
        }
    }
}
