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

    

}

public class InvalidInputException : Exception
{
    public InvalidInputException() : base("Invalid Input Exception") { }
}

public class SortingEvents
{
    public delegate void SortEventHandler(List<string> names);
    public event SortEventHandler SortEvent;

    public void OnSortEvent(List<string> names)
    {
        SortEvent?.Invoke(names);
    }

    public int Read()
    {
        Console.WriteLine("Введите число 1 для сортировки А-Я или число 2 для сортировки Я-А:");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input != 1 && input != 2) throw new InvalidInputException();
        return input;
    }
}

