internal class Program
{
    private static void Main(string[] args)
    {
        Exception[] exceptions = new Exception[]
        {
            new MyException(), 
            new ArgumentException(),
            new DivideByZeroException(), 
            new IndexOutOfRangeException(),
            new InvalidOperationException()
        };

        foreach (Exception ex in exceptions)
        {
            try
            {
                throw ex;
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}

public class MyException : Exception
{
    public MyException() : base("My Exception") { }
}