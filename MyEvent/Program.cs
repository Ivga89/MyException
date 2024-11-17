using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string> { "Иванов", "Петров", "Сидоров", "Алексеев", "Борисов" };

        SortingEvents sortingEvents = new SortingEvents();

        while (true)
        {
            try
            {
                int input = sortingEvents.Read();

                switch (input)
                {
                    case 1:
                        sortingEvents.OnSortEvent(names, SortOrder.Ascending);
                        break;
                    case 2:
                        sortingEvents.OnSortEvent(names, SortOrder.Descending);
                        break;
                }

                Console.WriteLine("Отсортированный список фамилий:");
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
            }
            catch (InvalidInputException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
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

public class InvalidInputException : Exception
{
    public InvalidInputException() : base("Invalid Input Exception") { }
}

public enum SortOrder
{
    Ascending,
    Descending
}

public class SortingEvents
{
    public delegate void SortEventHandler(List<string> names);

    public void OnSortEvent(List<string> names, SortOrder order)
    {
        switch (order)
        {
            case SortOrder.Ascending:
                SortAscending(names);
                break;
            case SortOrder.Descending:
                SortDescending(names);
                break;
        }
    }

    public int Read()
    {
        Console.WriteLine("Введите число 1 для сортировки А-Я или число 2 для сортировки Я-А:");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input != 1 && input != 2) throw new InvalidInputException();
        return input;
    }

    private void SortAscending(List<string> names)
    {
        names.Sort();
    }

    private void SortDescending(List<string> names)
    {
        names.Sort();
        names.Reverse();
    }
}