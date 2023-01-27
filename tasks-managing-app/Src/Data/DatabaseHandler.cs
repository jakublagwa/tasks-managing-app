using Java.IO;
using MySql.Data.MySqlClient;

class DatabaseHandler
{
    private MySqlConnection connection;

    public DatabaseHandler()
    {
        string connectionString = "Server=localhost;Database=mydatabase;Uid=root;Pwd=password;";
        connection = new MySqlConnection(connectionString)
    }

    public void OpenConnection()
    {
        connection.Open();
    }

    public void CloseConnection()
    {
        connection.Close();
    }

    public bool TestConnection()
    {
        try
        {
            OpenConnection();
            CloseConnection();
            return true;
        }
        catch (MySqlException ex)
        {
                          Console.WriteLine(ex.Message);
            return false;
        }
    }
    //TODO: correct this and end this file
}