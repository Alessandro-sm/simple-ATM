decimal balance = 1000m;

while (true)
{
    Console.WriteLine("1.- See balance");
    Console.WriteLine("2.- Deposit money");
    Console.WriteLine("3.- Withdraw money");
    Console.WriteLine("0.- Exit");

    Console.Write("Choose: ");
    int.TryParse(Console.ReadLine(), out int choice);
    
    if (choice == 0)
    {
        break;
    }
    else if (choice == 1)
    {
        Console.WriteLine($"Your Balance is {balance:F2}");
    }
    else if (choice == 2)
    {
        Console.WriteLine($"Your actual balance is {balance:F2}");
        Console.WriteLine();
    }

}
  