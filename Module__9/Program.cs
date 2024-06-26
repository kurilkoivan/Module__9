static void Main(string[] args)
{
    try
    {
        Console.WriteLine("Процесс начат.");
        throw new ArgumentOutOfRangeException();
    }

    catch (ArgumentOutOfRangeException ex)
    {
        Console.Write(ex.Message);
    }

    finally
    {
        Console.Read();
    }
}