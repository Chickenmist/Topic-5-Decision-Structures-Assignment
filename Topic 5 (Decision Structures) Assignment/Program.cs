namespace Topic_5__Decision_Structures__Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        public static void Menu()
        {
            BankMachine();
        }

        //Part 1
        public static void BankMachine()
        {
            string selectionCheck = "";
            double balance = 0, transactionFee = 0.75, depositWithdrawlPaymentAmount = 0, updatedBalance;
            int firstAccess = 0; //0 means it hasn't been accessed, 1 means it has. This is for tracking the bank balance

            if (firstAccess == 0)
            {
                balance = 150.00;
            }

            Console.WriteLine("-------WELCOME TO THE BANK OF BLORB-------");
            Console.WriteLine("");
            Console.WriteLine($"Balance: {balance.ToString("C")}");
            Console.WriteLine("");
            Console.WriteLine("PLEASE MAKE A SELECTION");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdrawl");
            Console.WriteLine("3. Bill Payment");
            Console.WriteLine("4. Account Balance Update");
            Console.WriteLine("");

            balance -= transactionFee;

            selectionCheck = Console.ReadLine().ToLower();

            if (selectionCheck == "1" || selectionCheck == "deposit")
            {
                Console.WriteLine("");
                Console.Write("Input deposit amount: ");
                double.TryParse(Console.ReadLine(), out depositWithdrawlPaymentAmount);
                Console.WriteLine("");

                if (depositWithdrawlPaymentAmount == 0)
                {
                    Console.WriteLine("Invalid deposit");
                }
                else
                {
                    balance += depositWithdrawlPaymentAmount;

                    Console.WriteLine("");
                    Console.WriteLine($"Deposit: {depositWithdrawlPaymentAmount.ToString("C")}");
                    Console.WriteLine($"Transaction Fee: {transactionFee.ToString("C")}");
                    Console.WriteLine($"Balance: {balance.ToString("C")}");
                }

            }
            else if (selectionCheck == "2" || selectionCheck == "withdrawl")
            {

            }
            else if (selectionCheck == "3" || selectionCheck == "bill payment")
            {

            }
            else if (selectionCheck == "4" || selectionCheck == "account balance update")
            {

            }
            else
            {
                Menu();
            }

        }
        //

        //Part 2
        public static void ParkingGarage()
        {

        }
        //

        //Part 3
        public static void Hurricane()
        {

        }
        //
    }
}