using School;
using MySql.Data.MySqlClient;

MySqlConnection connection = new MySqlConnection();

connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac3;password=welcome;database=dac3";

// 1. Select Query
     string query = "SELECT * FROM student";

// 2. Insert Query
//      Student s1 = new Student(42,"Anshu","Jaiswal","1998-03-19","anshujais1903.com");
//      string query ="INSERT INTO student(ID,namefirst,namelast,DOB,emailID)VALUES("+s1.ID+",'"+s1.namefirst+"','"+s1.namelast+"','"+s1.DOB+"','"+s1.emailID+"')";

// 3. Update Query 
        // Console.WriteLine("Enter the student ID");
        // int id = int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the student namefirst");
        // string namefirst = Console.ReadLine();
        // Console.WriteLine("Enter the student namelast");
        // string namelast = Console.ReadLine();
        // Console.WriteLine("Enter the student DOB(yyyy-mm-dd)");
        // string DOB = Console.ReadLine();
        // Console.WriteLine("Enter the student mail ID");
        // string mail = Console.ReadLine();

        // string query = "UPDATE student SET namefirst='"+namefirst+"',namelast='"+namelast+"',DOB='"+DOB+"',emailID='"+mail+"'WHERE ID="+id;

// 4. Delete Query

        // string query ="DELETE FROM login WHERE id=2";

MySqlCommand command = new MySqlCommand(query,connection);

try
{
    connection.Open();
    // command.ExecuteNonQuery();
                
    MySqlDataReader reader=command.ExecuteReader();

    while(reader.Read())
    {
       int id=int.Parse(reader["id"].ToString());
       string namefirst=reader["namefirst"].ToString();
       string namelast=reader["namelast"].ToString();
       string dob=reader["DOB"].ToString();
       string email=reader["emailID"].ToString();
       Console.WriteLine(id+"   "+namefirst+"   "+namelast+"   "+dob+"   "+email);
    }
    reader.Close();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    connection.Close();
}