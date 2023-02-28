namespace Change_Char;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your string: ");
        string input = Console.ReadLine();

        string[] words = input.Split(" ");
        List<string> newWords = new List<string>();

        for(int i = 0; i < words.Length; i++)
        {
            char firstChar = words[i][0];
            char lastChar = words[i][words[i].Length - 1];

            string newWord = lastChar + words[i].Substring(1, words[i].Length - 2) + firstChar;
            newWords.Add(newWord);
        }

        foreach (var item in newWords)
        {
            Console.Write(item + " ");
        }
    }
}
