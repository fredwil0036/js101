using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // check the connection for mysql
        using(var conn = ConnectionDB.GetConnection())
        {
            try
            {
                conn.Open();
                Display.ActionChoice();

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
      
    }
}