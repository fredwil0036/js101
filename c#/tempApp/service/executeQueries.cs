using MySql.Data.MySqlClient;
class ExecuteCmd()
{
    public static void ExecuteToRead(string query, Action<MySqlCommand> parameterize, Action<MySqlDataReader> handleResult)
    {
        try
        {
            using (var conn = ConnectionDB.GetConnection())
        {
            conn.Open();

            var cmd = new MySqlCommand(query, conn);
            parameterize?.Invoke(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                handleResult(reader);
            }
        }
        }
        catch (Exception Error)
        {   
            Console.WriteLine("Error" + Error.Message);
        }
        
        }

    // execute for non query
    public static void ExecuteForNonQuery(string query, Action<MySqlCommand> parameterize)
    {
        using (var conn = ConnectionDB.GetConnection())
        {
            conn.Open();
            var cmd = new MySqlCommand(query, conn);
            parameterize?.Invoke(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}