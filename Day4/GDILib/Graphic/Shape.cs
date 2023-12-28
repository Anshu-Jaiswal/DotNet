namespace Nilesh.Drawing;


public abstract class Shape{

    public Shape()
    {
        this.Color="black";
        this.width=0;
    }

    public Shape(int w,string Color){
        this.Color=Color;
        this.width=w;
    }

    public abstract void Draw();
    public int width{get; set;}
    public String Color{get;set;}

    public override string ToString()
    {
        return  "Width="+ this.width + ",  Color="+this.Color;
    }


}
