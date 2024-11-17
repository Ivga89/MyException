internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string> { "Иванов", "Петров", "Сидоров", "Алексеев", "Борисов" };

    }

    static void SortAscending(List<string> names)
    {
        names.Sort();
    }

    static void SortDescending(List<string> names)
    {
        names.Sort();
        names.Reverse();
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

