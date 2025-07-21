

decimal balance = 1000m;
bool keepRunning = true;

Console.WriteLine("Welcome to Bank ATM!\n");

    while (keepRunning)
    {
        Console.WriteLine("\nSelect an option:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Exit");
        Console.Write("Your choice: ");

        string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine($"Your balance is: KES {balance}");
            break;

        case "2":
            Console.Write("Enter amount to deposit: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());
            balance += deposit;
            Console.WriteLine($"Deposited KES {deposit}. New balance: KES {balance}");
            break;

        case "3":
            Console.Write("Enter amount to withdraw: ");
            decimal withdraw = Convert.ToDecimal(Console.ReadLine());

            if (withdraw <= balance)
            {
                balance -= withdraw;
                Console.WriteLine($" Withdrawn KES {withdraw}. Remaining balance: KES {balance}");
            }
            else
            {
                Console.WriteLine(" Insufficient funds!..Too Broke!!");
            }
            break;

        case "4":
            Console.WriteLine("Thank you for using Wachira ATM. Goodbye!");
            keepRunning = false;
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;   

    }
    }

