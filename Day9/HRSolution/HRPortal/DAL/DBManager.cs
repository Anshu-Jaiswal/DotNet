using HRPortal.Models;
using MySql.Data.MySqlClient;

namespace DAL;

public static class HRDBManager
{
    public static void Insert(Company cs)
    {
        MySqlConnection connection = new MySqlConnection();

        connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac3;password=welcome;database=dac3";
        Console.WriteLine(cs.Firstname + cs.Lastname + cs.Phone + cs.Address + cs.Password +" In DAO");
        string query = "insert into forminfo(firstname,lastname,phone,address,password)values('"+cs.Firstname+"','"+cs.Lastname+"','"+cs.Phone+"','"+cs.Address+"','"+cs.Password+"')";

        MySqlCommand command = new MySqlCommand(query,connection);

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
    }


}