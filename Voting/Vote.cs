namespace Voting;

public class Vote
{
    public static List<string> categories = new List<string>();
    
    public static void categoryList()
    {
        categories.Add("Film Kategorileri");
        categories.Add("Tech Stack Kategorileri");
        categories.Add("Spor Kategorileri");

        foreach(var category in categories)
        {
            Console.WriteLine(category);
        }
    }
}