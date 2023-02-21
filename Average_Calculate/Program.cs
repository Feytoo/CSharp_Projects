namespace Average_Calculate;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lutfen Fibonacci serisinin derinligini giriniz: ");
        int depth = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Fibonacci serisinin ortlamasi: {Fibonacci.fibonacci_average(depth)}");
    }
}
