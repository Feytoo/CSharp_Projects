using System.Reflection.Metadata;
namespace ATM;
public class Register
{
    public class Singing
    {
        public static List<Entities.Users> users = new List<Entities.Users>();

        public static bool UserCheck()
        {
            Console.Write("Please enter your ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your password: ");
            string pass = Console.ReadLine();
            Logger log = new Logger();

            foreach (var user in users)
            {
                if(id == user.ID && pass == user.password)
                {
                    Console.WriteLine("You are successfully logged in!");
                    return true;
                }
                else
                {
                    string message = "Fraud Transaction Detected";
                    Console.WriteLine("Wrong ID or Password!");
                    log.WriteFile(message);
                    return false;
                }
            }
            return true;
        }
    }
}
