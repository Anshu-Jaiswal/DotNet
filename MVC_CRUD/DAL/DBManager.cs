namespace DAL;
using BOL;
using MySql.Data.MySqlClient;


public static class DBManager{

    public static void insert(Employee emp){
        MySQlConnection conncetion = new MySQlConnection();
        conncetion.ConnectionString="server=localhost;port=3306;user=root;password=Anshujais;database=anshu";
        Console.WriteLine(emp.id+emp.name+emp.designation+emp.company+emp.salary+emp.username+emp.password);
        string query = "insert into employee values('"+emp.id+"','"+emp.name+"','"+emp.designation+"','"+emp.company+"','"+emp.salary+"','"+emp.username+"','"+emp.password+"')";
        MySqlCommand command = new MySqlCommand(query,conncetion);
        try{
             conncetion.Open();
              command.ExecuteNonQuery();
        }
        catch(Exception e){
            Console.WriteLine("Exception is "+e.Message);
        }
        finally{
            conncetion.Close();
        }



    }



}