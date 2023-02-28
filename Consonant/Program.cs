namespace Consonant;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your string: ");
        string input = Console.ReadLine();

        string[] words = input.Split(" ");
        string consonants = "bcdfghjklmnpqrstvwxyz";
        
        foreach (string word in words)
        {
            bool hasConsonants = false;

            for(int i = 0; i < word.Length-1 ; i++)
            {
                if(consonants.Contains(word[i]) && consonants.Contains(word[i+1]))
                {
                    hasConsonants = true;
                    break;
                }
            }

            Console.Write(hasConsonants + " ");
        }
    }
}
