internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    
}

public class MyException : Exception
{
    public MyException() : base("My Exception") { }
}