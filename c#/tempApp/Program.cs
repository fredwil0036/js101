using System;
using System.Collections.Generic;
using System.Linq;

class Wire
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Length { get; set; }
    public int Quantity { get; set; }

    public void Display()
    {
        Console.WriteLine($"ID: {Id} | Wire: {Name}, Length: {Length}m, Stock: {Quantity}");
    }
}

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
                    AddWire();
                    break;
                case 2:
                    ViewWires();
                    break;
                case 3:
                    UpdateWire();
                    break;
                case 4:
                    DeleteWire();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddWire()
    {
        Wire wire = new Wire();

        wire.Id = nextId++; // AUTO-INCREMENT

        Console.Write("Enter wire name: ");
        wire.Name = Console.ReadLine();

        Console.Write("Enter length (meters): ");
        wire.Length = double.Parse(Console.ReadLine());

        Console.Write("Enter quantity: ");
        wire.Quantity = int.Parse(Console.ReadLine());

        inventory.Add(wire);
        Console.WriteLine("Wire added successfully!");
    }

    static void ViewWires()
    {
        Console.WriteLine("\n--- Wire List ---");

        if (inventory.Count == 0)
        {
            Console.WriteLine("No wires available.");
            return;
        }

        foreach (var wire in inventory)
        {
            wire.Display();
        }
    }

    static void UpdateWire()
    {
        Console.Write("Enter ID to update: ");
        int id = int.Parse(Console.ReadLine());

        var wire = inventory.FirstOrDefault(w => w.Id == id);

        if (wire == null)
        {
            Console.WriteLine("Wire not found!");
            return;
        }

        Console.Write("Enter new name: ");
        wire.Name = Console.ReadLine();

        Console.Write("Enter new length: ");
        wire.Length = double.Parse(Console.ReadLine());

        Console.Write("Enter new quantity: ");
        wire.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("Wire updated successfully!");
    }

    static void DeleteWire()
    {
        Console.Write("Enter ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        var wire = inventory.FirstOrDefault(w => w.Id == id);

        if (wire == null)
        {
            Console.WriteLine("Wire not found!");
            return;
        }

        inventory.Remove(wire);
        Console.WriteLine("Wire deleted successfully!");
    }
}