using System;

class Display
{
    public static void ActionChoice()
    {
        while (true)
        {
            Console.WriteLine("\n=== Wiring Inventory System ===");
            Console.WriteLine("1. Add Wire");
            Console.WriteLine("2. View Wires");
            Console.WriteLine("3. Update Wire");
            Console.WriteLine("4. Delete Wire");
            Console.WriteLine("5. Exit");
            Console.Write("Choose: ");

             int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    Crud.AddWire();
                    break;
                case 2:
                    Crud.ViewWire();
                    break;
                case 3:
                    Crud.UpdateWire();
                    break;
                case 4:
                    Crud.DeleteWire();
                    break;
                case 5:
                return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}