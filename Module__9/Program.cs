namespace DelegatePractices
{
    class Program
    {
        delegate int CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {

            CalculateDelegate calcDelegate = Calculate;
            int result = calcDelegate.Invoke(100, 30);
            Console.WriteLine(result);

            CalculateDelegate calcDelegate2 = Calculate;
            int result2 = calcDelegate(100, 30);
            Console.WriteLine(result2);
            Console.Read();

        }

        static int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}