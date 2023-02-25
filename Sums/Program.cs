namespace Sums;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter int values with spaces = ");
        string input = Console.ReadLine();

        string[] integers = input.Split(" ");
        List<int> sums = new List<int>();
        int sum = 0;

        for (int i = 0; i < integers.Length; i += 2)
        {
            if (integers[i] != integers[i+1])
            {
                sum = Convert.ToInt32(integers[i]) + Convert.ToInt32(integers[i+1]);
                sums.Add(sum);
                sum = 0;
            }
            else if (integers[i] == integers[i+1])
            {
                sum = Convert.ToInt32(integers[i]) * Convert.ToInt32(integers[i]);
                sums.Add(sum);
                sum = 0;
            }
        }

        foreach (var item in sums)
        {
            Console.Write(item + " ");
        }
    }
}
