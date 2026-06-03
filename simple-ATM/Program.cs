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
            if (!decimal.TryParse(Console.ReadLine(), out decimal deposited) || deposited < 0)
            {
                Console.WriteLine("Invalid deposit: Please enter a valid number");
                continue;
            }

            balance += deposited;

            Console.WriteLine($"You have deposited {deposited} in your balance");
            break;
        }
    }
    else if (choice == 3)
    {
        while (true)
        {

        }
    }
}
  