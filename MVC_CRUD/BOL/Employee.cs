namespace BOL;

public class Employee{

    public int id{get;set;}
    public string name{get;set;}

    public string designation{get;set;}

    public string company{get;set;}
    public double salary{get;set;}

    public string username{get;set;}
    public string password{get;set;}

    public Employee(){
        
    }

    public Employee(int id,string name,string designation,string company,double salary,string username,string password){
        this.id=id;
        this.name=name;
        this.designation=designation;
        this.company=company;
        this.salary=salary;
        this.username=username;
        this.password=password;
    }


}