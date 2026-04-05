using MySql.Data.MySqlClient;

class Crud
{

    
  public static void AddWire(ref int nextID, List<Wire> inventory)
    {

        var Name = ValidationService.GetValidName();
        double Length = ValidationService.GetValidDouble("Enter length (meters): ");
        int Quantity = ValidationService.GetValidInt("Enter quantity: ");

        using(var conn = ConnectionDB.GetConnection())
        {
            conn.Open();
                        string query = "INSERT INTO wires (wire_name, length, quantity) VALUES (@wire_name, @length, @quantity)";
            var cmd = new MySqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@wire_name",Name);
            cmd.Parameters.AddWithValue("@length",Length);
            cmd.Parameters.AddWithValue("@quantity",Quantity);
            cmd.ExecuteNonQuery();

        }        

        Console.WriteLine("Wire added successfully!");
    }

    public static void ViewWire(ref List<Wire> inventory)
    {
        using(var conn = ConnectionDB.GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM wires";
            var cmd = new MySqlCommand(query,conn);
            var reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- Wire List ---");
            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader["id"]} | Name: {reader["wire_name"]} | Length: {reader["length"]}m | Qty: {reader["quantity"]}");
            }
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