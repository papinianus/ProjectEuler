using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Enumerable.Range(0, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum());
    }
}