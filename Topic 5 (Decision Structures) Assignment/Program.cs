﻿namespace Topic_5__Decision_Structures__Assignment
{
    internal class Program
    {
        //Wilson
        
        static void Main(string[] args)
        {
            Menu();
        }


        public static void Menu()
        {
            string selection = "";

            Console.WriteLine("-------WELCOME TO THE MENU-------");
            Console.WriteLine("Please select a program:");
            Console.WriteLine("Bank");
            Console.WriteLine("Parking");
            Console.WriteLine("Hurricane");

            while (selection == "")
            {
                selection = Console.ReadLine().ToLower();

                if (selection == "bank")
                {
                    Console.WriteLine("");
                    BankMachine();
                }
                else if (selection == "parking")
                {
                    Console.WriteLine("");
                    ParkingGarage();
                }
                else if (selection == "hurricane")
                {
                    Console.WriteLine("");
                    Hurricane();
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                    Console.Write("Select a program: ");
                    Console.WriteLine("");
                }
            }

        }

        //Part 1
        public static void BankMachine()
        {
            Random random = new Random();
            string selectionCheck = "";
            double balance = random.Next(100, 151), transactionFee = 0.75, depositWithdrawlPaymentAmount = 0;

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
                    Console.WriteLine($"Transaction Fee: {transactionFee.ToString("C")}");
                    Console.WriteLine($"Balance: {balance.ToString("C")}");
                }
                else
                {
                    balance += depositWithdrawlPaymentAmount;

                    Console.WriteLine($"Deposit: {depositWithdrawlPaymentAmount.ToString("C")}");
                    Console.WriteLine($"Transaction Fee: {transactionFee.ToString("C")}");
                    Console.WriteLine($"Balance: {balance.ToString("C")}");
                }

            }
            else if (selectionCheck == "2" || selectionCheck == "withdrawl")
            {
                Console.WriteLine("");
                Console.Write("Input withdrawl amount: ");
                double.TryParse(Console.ReadLine(), out depositWithdrawlPaymentAmount);
                Console.WriteLine("");

                if (depositWithdrawlPaymentAmount == 0 || depositWithdrawlPaymentAmount > balance)
                {
                    Console.WriteLine("Invalid withdrawl");
                    Console.WriteLine($"Transaction Fee: {transactionFee.ToString("C")}");
                    Console.WriteLine($"Balance: {balance.ToString("C")}");
                }
                else
                {
                    balance -= depositWithdrawlPaymentAmount;

                    Console.WriteLine($"Withdrawl: {depositWithdrawlPaymentAmount.ToString("C")}");
                    Console.WriteLine($"Transaction Fee: {transactionFee.ToString("C")}");
                    Console.WriteLine($"Balance: {balance.ToString("C")}");
                }
            }
            else if (selectionCheck == "3" || selectionCheck == "bill payment")
            {
                Console.WriteLine("");
                Console.Write("Input payment amount: ");
                double.TryParse(Console.ReadLine(), out depositWithdrawlPaymentAmount);
                Console.WriteLine("");

                if (depositWithdrawlPaymentAmount > balance || depositWithdrawlPaymentAmount == 0)
                {
                    Console.WriteLine("Invalid payment amount");
                    Console.WriteLine($"Transaction Fee: {transactionFee.ToString("C")}");
                    Console.WriteLine($"Balance: {balance.ToString("C")}");
                }
                else
                {
                    balance -= depositWithdrawlPaymentAmount;

                    Console.WriteLine($"Payment Amount: {depositWithdrawlPaymentAmount.ToString("C")}");
                    Console.WriteLine($"Transaction Fee: {transactionFee.ToString("C")}");
                    Console.WriteLine($"Balance: {balance.ToString("C")}");
                }
            }
            else if (selectionCheck == "4" || selectionCheck == "account balance update")
            {
                Console.WriteLine("");
                Console.WriteLine($"Transaction Fee: {transactionFee.ToString("C")}");
                Console.WriteLine($"Updated Balance: {balance.ToString("C")}");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"Transaction Fee: {transactionFee.ToString("C")}");
                Console.WriteLine($"Balance: {balance.ToString("C")}");
            }

            Console.WriteLine("");
            Console.WriteLine("-------THANK YOU FOR CHOOSING THE BANK OF BLORB-------");
            Console.WriteLine("");
            Menu();
        }
        //

        //Part 2
        public static void ParkingGarage()
        {
            double hours, minutes, payment;
            Console.WriteLine("-------SAM'S PARKING GARAGE-------");
            Console.WriteLine("");
            Console.WriteLine("How many minutes were you parked for?");

            double.TryParse(Console.ReadLine(), out minutes);


            hours = minutes/60;

            if (Math.Ceiling(hours) == 1)
            {
                payment = 4;
            }
            else
            {
                payment = 4 + 2 * Math.Ceiling(hours);

                if (payment > 20)
                {
                    payment = 20;
                }
            }

            Console.WriteLine($"Hours Parked: {Math.Ceiling(hours)}");
            Console.WriteLine($"Cost: {payment.ToString("C")}");
            Console.WriteLine("");
            Console.WriteLine("-------THANK YOU FOR YOUR STAY-------");
            Console.WriteLine("");
            Menu();
        }
        //

        //Part 3
        public static void Hurricane()
        {
            int hurricaneLevel = 0;

            Console.WriteLine("-------HURRICANE CHECKER-------");
            Console.Write("Welcome to the hurricane checker. Enter what catagory of hurricane (1-5) you want to check the wind speed of: ");

            while (hurricaneLevel == 0 || hurricaneLevel > 5)
            {
                int.TryParse(Console.ReadLine(), out hurricaneLevel);
            }

            switch (hurricaneLevel)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Wind Speed of a Catagory 1 Hurricane: 74-95 mph or 64-82 kt or 119-153 km/h");
                
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Wind Speed of a Catagory 2 Hurricane: 96-110 mph or 83-95 kt or 154-177 km/h");
                    
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Wind Speed of a Catagory 3 Hurricane: 111-130 mph or 96-113 kt or 178-209 km/h");
                    
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Wind Speed of a Catagory 4 Hurricane: 131-155 mph or 114-135 kt or 210-249 km/h");
                    
                    break;

                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("Wind Speed of a Catagory 5 Hurricane: greater than 155 mph, 135 kt or 249 km/h");
                    
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("-------THAT'S QUITE FAST-------");
            Console.WriteLine("");
            Menu();
        }
        //
    }
}