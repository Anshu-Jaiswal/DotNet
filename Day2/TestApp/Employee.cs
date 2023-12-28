namespace HR;

class Employee{
    private int id;

    public int Id{
        get{return this.id;}
        set{this.id=value;}
    }
   
   public string FullName{
    get;set;
   }
   public Employee():this(24,"Anshu Jaiswal"){}

   public Employee(int id,string name){
    this.id = id;
    this.FullName=name;
   }

 public virtual float computePay(){
     return 56000;
 }

  public override string ToString(){
    return "Employee id is "+id +" FullName is "+FullName;
  }





}