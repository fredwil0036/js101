using MySql.Data.MySqlClient;

class ConnectionDB
{
    public static MySqlConnection GetConnection()
    {
        string connectionString = "server=localhost;port=3306;database=wire;user=root;password=;";
        return new MySqlConnection(connectionString);
    }
}