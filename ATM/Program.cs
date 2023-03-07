namespace ATM;
class Program
{
    static void Main(string[] args)
    {
        Entities.Users user = new Entities.Users();
        user.ID = 1;
        user.password = "2867";
        user.budget = 15000;
        Logger log = new Logger();
        
        if (Register.Singing.UserCheck())
        {
            Console.Write("Please select what you want to do: \n1- Withdraw. \n2-Deposit. \n3-Balance Inquiry. \n4-Log Records");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Business.Transactions.withDraw(user.budget);
                    break;
                case 2:
                    Business.Transactions.deposit(user.budget);
                    break;
                case 3:
                    Business.Transactions.balance(user.budget);
                    break;
                case 4:
                    log.EndOfTheDayReadFile();
                    break;
            }
        }

    }
}
