namespace Algorithm;

public class Algoritma
{
    public static string write_word(string word)
    {
        string[] words = word.Split(',');
        string stringInput = words[0];
        int indexInput = int.Parse(words[1]);

        string newWord = stringInput.Remove(indexInput, 1);

        return newWord;
    }
}