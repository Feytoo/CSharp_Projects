namespace ATM;
public class Business
{
    public class Transactions
    {
        static Logger log = new Logger();
        public static void withDraw(int budget)
        {
            string message = "Money Withdraw!";
            int newbudget;
            Console.Write("Please enter the amount you want to withdraw: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= budget)
            {
                newbudget = budget - input;
                Console.WriteLine("Your new budget is " + newbudget);
            }
            else
            {
                Console.WriteLine("Your budget isn't enough to withdraw!");
            }
            log.WriteFile(message);
        }

        public static void deposit(int budget)
        {
            string message = "Deposit money!";
            Console.Write("Please enter the amount you want to deposit: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int newbudget = budget + input;
            Console.WriteLine("Your budget is " + newbudget);
            log.WriteFile(message);
        }

        public static void balance(int budget)
        {
            string message = "Balance Inquiry!";
            Console.WriteLine("Your budget is "+ budget);
            log.WriteFile(message);
        }
    }
}
