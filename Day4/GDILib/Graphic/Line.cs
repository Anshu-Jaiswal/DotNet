using Hardware;

namespace Nilesh.Drawing;

public class Line : Shape,IPrinter{

    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}

    public Line() :base(){
        this.StartPoint = new Point(0,0);
        this.EndPoint= new Point(0,0);
    }

       public Line(Point p1, Point p2, int w, string c):base(w,c){
        this.StartPoint=p1;
        this.EndPoint=p2;
    }

       public override string ToString()
    {
        return base.ToString() + this.StartPoint + ", "+ this.EndPoint;
    }
    
    public override void Draw(){
    Console.WriteLine("Drawing Line");
        Console.WriteLine(this);

    }


    void IPrinter.Print(){
         Console.WriteLine("Printing  Line");
         Console.WriteLine(this);
    }

   

}