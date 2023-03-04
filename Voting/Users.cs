namespace Voting;

public class Users
{
    public static List<string> users = new List<string>();
    public static void newUser(string username)
    {
        users.Add(username);
    }

    public static bool isUser(string username)
    {
        if(users.Contains(username))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}