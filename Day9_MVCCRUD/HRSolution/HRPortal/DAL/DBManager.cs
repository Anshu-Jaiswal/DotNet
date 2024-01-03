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

    public static void delete(int id){

         MySqlConnection connection = new MySqlConnection();

        connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac3;password=welcome;database=dac3";
        string query = "delete from formInfo where id="+id+"";

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

    public static void Update(Company cs)
    {
        MySqlConnection connection = new MySqlConnection();

        connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac3;password=welcome;database=dac3";
        Console.WriteLine(cs.Firstname + cs.Lastname + cs.Phone + cs.Address + cs.Password +" In DAO");
        string query = "update formInfo set firstname='"+cs.Firstname+"',lastname='"+cs.Lastname+"',phone='"+cs.Phone+"',address='"+cs.Address+"' where id="+cs.id+"";

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

    public static Company Display(int id)
    {
        MySqlConnection connection = new MySqlConnection();

        connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac3;password=welcome;database=dac3";
        string query = "Select * from formInfo where id='"+id+"'";

        MySqlCommand command = new MySqlCommand(query,connection);

        Company cs = null;

        try
        {
            connection.Open();
            MySqlDataReader reader=command.ExecuteReader();
            Company c = new Company();
            while(reader.Read())
            {
                c.id = int.Parse(reader["id"].ToString());
                c.Firstname = reader["firstname"].ToString();
                c.Lastname = reader["lastname"].ToString();
                c.Phone = reader["phone"].ToString();
                c.Address = reader["address"].ToString();
            }
            Console.WriteLine(c.id);
            return c;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
        finally
        {
            connection.Close();
        }
        

    }

  public static List<Company> DisplayAll()
    {
        MySqlConnection connection = new MySqlConnection();

        connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac3;password=welcome;database=dac3";
        string query = "select id,firstname,lastname,phone,address from forminfo;";

        MySqlCommand command = new MySqlCommand(query,connection);

        List<Company> ls = new List<Company>();

        try
        {
            connection.Open();
            MySqlDataReader reader=command.ExecuteReader();
            
            while(reader.Read())
            {
                Company c = new Company();
                c.id = int.Parse(reader["id"].ToString());
                c.Firstname = reader["firstname"].ToString();
                c.Lastname = reader["lastname"].ToString();
                c.Phone = reader["phone"].ToString();
                c.Address = reader["address"].ToString();

                ls.Add(c);
            }
            return ls;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
        finally
        {
            connection.Close();
        }
        

    }


}