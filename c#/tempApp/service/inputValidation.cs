class ValidationService
{
    public static string GetValidName()
    {
        string input;
        do
        {
            Console.Write("Enter wire name: ");
            input = Console.ReadLine()!;

              if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("❌ Error: Wire name cannot be empty. Please try again.");
                }
        } 
        while (string.IsNullOrWhiteSpace(input));
        return input;
    }

    public static double GetValidDouble(string message)
    {
        double value;
        Console.Write(message);

        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Try again: ");
        }

        return value;
    }

    public static int GetValidInt(string message)
    {
        int value;
        Console.Write(message);

        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Try again: ");
        }

        return value;
    }
}