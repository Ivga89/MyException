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

public class SortingEvents
{
    public delegate void SortEventHandler(List<string> names);
    public event SortEventHandler SortEvent;

    public void OnSortEvent(List<string> names)
    {
        SortEvent?.Invoke(names);
    }
}