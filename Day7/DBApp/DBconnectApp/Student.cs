namespace School;

public class Student
{
    public int ID;
    public string namefirst;
    public string namelast;
    public string DOB;
    public string emailID;

    public Student(int ID,string namefirst,string namelast,string DOB,string emailID)
    {
        this.ID=ID;
        this.namefirst=namefirst;
        this.namelast=namelast;
        this.DOB=DOB;
        this.emailID=emailID;
    }
}