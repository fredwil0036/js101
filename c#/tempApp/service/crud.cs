class Crud
{
  public static void AddWire(ref int nextID, List<Wire> inventory)
    {
        Wire wire = new Wire();

        wire.Name = ValidationService.GetValidName();
        wire.Length = ValidationService.GetValidDouble("Enter length (meters): ");
        wire.Quantity = ValidationService.GetValidInt("Enter quantity: ");

        wire.Id = nextID++;

        inventory.Add(wire);

        Console.WriteLine("Wire added successfully!");
    }

    public static void ViewWire(ref List<Wire> inventory)
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


    public static void UpdateWire(ref List<Wire> inventory)
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

    public static void DeleteWire(ref List<Wire> inventory)
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