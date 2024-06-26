static void Main(string[] args)
{
    try
    {
        Console.WriteLine("Процесс начат.");
        throw new RankException();
    }

    catch (RankException ex)
    {
        Console.Write(ex.GetType());
    }

    finally
    {
        Console.Read();
    }

}