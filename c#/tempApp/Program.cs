using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Wire> inventory = new List<Wire>();
    static int nextId = 1; // AUTO-INCREMENT ID

    static void Main()
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

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // filepath:  controller / crudController.cs 
                    Crud.AddWire(ref nextId,inventory);
                    break;
                case 2:
                    Crud.ViewWire(ref inventory);
                    break;
                case 3:
                    Crud.UpdateWire(ref inventory);
                    break;
                case 4:
                    Crud.DeleteWire(ref inventory);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }


}