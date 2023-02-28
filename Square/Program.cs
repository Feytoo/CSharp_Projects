namespace Square;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your integers with spaces: ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(" ");
        List<int> result = new List<int>();
        int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (Convert.ToInt32(numbers[i]) < 67)
            {
                sum1 = 67 - Convert.ToInt32(numbers[i]);
                sum4 += sum1;
            }
            else if (Convert.ToInt32(numbers[i])>67)
            {
                sum2 = (Convert.ToInt32(numbers[i]) - 67)*(Convert.ToInt32(numbers[i])-67);
                sum3 += sum2;
                sum2 = 0;
            }
        }

        result.Add(sum4);
        result.Add(sum3);

        foreach(var item in result)
        {
            Console.Write(item + " ");
        }
    }
}
