namespace Voting;
class Program
{
    static void Main(string[] args)
    {
        int vote1=0,vote2=0,vote3=0;
        Console.Write("Please enter username: ");
        string username = Console.ReadLine();
        baslangic:
        if(Users.isUser(username))
        {
            Vote.categoryList();
            Console.WriteLine("***********************************************");
            Console.Write("Please select a category: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                vote1++;
            }
            else if(input == 2)
            {
                vote2++;
            }
            else if(input == 3)
            {
                vote3++;
            }

        }
        else
        {
            Console.Write("Please enter a username to login: ");
            string user =   Console.ReadLine();
            Users.newUser(user);
            goto baslangic;
        }
        Console.WriteLine("***********************************************");
        Console.WriteLine($"{username} your vote is saved!");
        Console.WriteLine($"Film Kategorileri: {vote1}");
        Console.WriteLine($"Tech Kategorileri: {vote2}");
        Console.WriteLine($"Spor Kategorileri: {vote3}"); 
    }
}
