decimal balance = 1000m;
bool exit = false;

static void ShowOptions()
{
    Console.WriteLine("======================================");
    Console.WriteLine("============= SIMPLE ATM =============");
    Console.WriteLine("======================================");
    Console.WriteLine("1.- See balance");
    Console.WriteLine("2.- Deposit money");
    Console.WriteLine("3.- Withdraw money");
    Console.WriteLine("0.- Exit");
}

static void ShowBalance(decimal balance)
{
    Console.WriteLine($"Your balance is {balance:F2}");
}

static decimal DepositMoney(decimal balance)
{
    while (true)
    {
        Console.WriteLine("How much would you like to deposit?: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal deposited) || deposited <= 0)
        {
            Console.WriteLine("Invalid deposit: Please enter a valid character");
            continue;
        }

        balance += deposited;

        Console.WriteLine($"You have deposited {deposited:F2} in your balance");
        return balance;
    }
}

static decimal WithdrawnMoney(decimal balance)
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
            Console.WriteLine("Insufficient balance");
            continue;
        }

        balance -= withdrawn;
        Console.WriteLine($"You have withdrawn {withdrawn:F2} from your balance");
        return balance;
    }
}

while (true)
{
    ShowOptions();

    Console.Write("Choose: ");
    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid input. Please enter a valid number");
        continue;
    }

    switch (choice)
    {
        case 0:
            Console.WriteLine("Closing...");
            exit = true;
            break;

        case 1:
            ShowBalance(balance);
            break;

        case 2:
            balance = DepositMoney(balance);
            break;

        case 3:
            balance = WithdrawnMoney(balance);
            break;

    }
    if (exit)
    {
        break;
    }
    Console.WriteLine("would you like to come back to the menu? (y/n)");
    String back_to_menu = Console.ReadLine();
    
    if (!string.IsNullOrEmpty(back_to_menu) && char.ToLower(back_to_menu[0]) == 'n')
    {
        break;
    }

}