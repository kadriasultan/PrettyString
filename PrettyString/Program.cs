using System;

public static class PrettyString
{
    public static string AddXs(string input)
    {
        return $"x{input}x";
    }

    public static string AddStars(string input)
    {
        return $"* {input}*";
    }
}


class Program
{
    static void Main(string[] args)
    {
        string result1 = PrettyString.AddXs("Hallo");
        Console.WriteLine(result1);


        string result2 = PrettyString.AddStars("Hallo");
        Console.WriteLine(result2);
    }
}