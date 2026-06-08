decimal balance = 1000m;

while (true)
{
    Console.WriteLine("======================================");
    Console.WriteLine("============= SIMPLE ATM =============");
    Console.WriteLine("======================================");
    Console.WriteLine("1.- See balance");
    Console.WriteLine("2.- Deposit money");
    Console.WriteLine("3.- Withdraw money");
    Console.WriteLine("0.- Exit");

    Console.Write("Choose: ");
    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid input. Please enter a valid number");
        continue;
    }
    
    if (choice == 0)
    {
        Console.WriteLine("Closing...");
        break;
    }
    else if (choice == 1)
    {
        Console.WriteLine($"Your Balance is {balance:F2}");
    }
    else if (choice == 2)
    {
        while (true)
        {
            Console.Write("How much would you like to deposit?: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal deposited) || deposited <= 0)
            {
                Console.WriteLine("Invalid deposit: Please enter a valid character");
                continue;
            }

            balance += deposited;

            Console.WriteLine($"You have deposited {deposited:F2} in your balance");
            break;
        }
    }
    else if (choice == 3)
    {
        while (true)
        {
            Console.WriteLine("How much would you like to withdraw?: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal withdrawn) || withdrawn <= 0)
            {
                Console.WriteLine("Invalid withdraw: Please enter valid character");
                continue;
            }
            else if (withdrawn > balance)
            {
                Console.WriteLine("insufficient balance");
                continue;
            }
            
            balance -= withdrawn;
            Console.WriteLine($"You have withdrawn {withdrawn:F2} from your balance");
            break;
        }
    }
}
  