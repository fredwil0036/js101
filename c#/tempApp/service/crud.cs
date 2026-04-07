using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;

class Crud
{
    public static bool HasData()
{
    using (var conn = ConnectionDB.GetConnection())
    {
        conn.Open();
        
        // We use COUNT(*) to get the total number of rows
        string query = "SELECT COUNT(*) FROM wires";
        var cmd = new MySqlCommand(query, conn);

        // ExecuteScalar is used when you expect a single value (like a count or sum)
        int count = Convert.ToInt32(cmd.ExecuteScalar());

        return count > 0;
    }
}


    
    public static void AddWire()
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

    public static void ViewWire()
    {
         if (!HasData())
        {
            Console.WriteLine("There no a Wire");
            return;
        }
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


   public static void UpdateWire()
{
    using (var conn = ConnectionDB.GetConnection())
    {
        conn.Open();
        if (!HasData())
        {
            Console.WriteLine("There no a Wire");
            return;
        }
        Console.Write("Enter ID to update: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID format.");
            return;
        }

        // 1. Check if ID exists (Using 'wires' as the table name)
        string checkQuery = "SELECT COUNT(*) FROM wires WHERE id = @id";
        var checkCmd = new MySqlCommand(checkQuery, conn);
        checkCmd.Parameters.AddWithValue("@id", id);
        
        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

        if (count == 0)
        {
            Console.WriteLine("Error: ID not found");
            return;
        }

        // 2. Get validated data
        string wire_name = ValidationService.GetValidName();
        double length = ValidationService.GetValidDouble("Enter length (meters): ");
        int quantity = ValidationService.GetValidInt("Enter quantity: ");

        // 3. Perform Update (Fixed syntax and spelling)
        // Removed the extra '=' after SET and fixed 'lenght' to 'length'
        string updateQuery = "UPDATE wires SET wire_name = @wire_name, length = @length, quantity = @quantity WHERE id = @id";
        
        var updateCmd = new MySqlCommand(updateQuery, conn);
        updateCmd.Parameters.AddWithValue("@wire_name", wire_name);
        updateCmd.Parameters.AddWithValue("@length", length);
        updateCmd.Parameters.AddWithValue("@quantity", quantity);
        updateCmd.Parameters.AddWithValue("@id", id); // Added the missing ID parameter

        updateCmd.ExecuteNonQuery();

        Console.WriteLine("Wire updated successfully!");
    }
}

    public static void DeleteWire()
    {
        if (!HasData())
        {
            Console.WriteLine("There no a Wire");
            return;
        }
         using(var conn = ConnectionDB.GetConnection())
        {
            conn.Open();
            // check if there is a data 

            int id = ValidationService.GetValidInt("Enter Id to delete: ");

            string checkQuery = "SELECT COUNT(*) FROM wires WHERE id = @id";
            var checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@id", id);
            
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count == 0)
            {
                Console.WriteLine("Error: ID not found");
                return;
            }
            // delete query
            string deleteQuery="DELETE FROM wires WHERE id = @id";
            // delete cmd
            var deleteCmd= new MySqlCommand(deleteQuery,conn);
            deleteCmd.Parameters.AddWithValue("@id",id);
            deleteCmd.ExecuteNonQuery();

            Console.WriteLine($"ID {id} was deleted successfully");

        }
    }

}