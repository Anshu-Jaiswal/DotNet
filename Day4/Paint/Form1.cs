using Nilesh.Drawing;
using System.Drawing;
using System.Windows;
namespace Paint;

public partial class Form1 : Form
{
     Nilesh.Drawing.Point startPoint;
     Nilesh.Drawing.Point endPoint;

    public Form1()
    {  
      InitializeComponent();
        Paint+=new System.Windows.Forms.PaintEventHandler(OnPaint);   
        MouseDown+=new System.Windows.Forms.MouseEventHandler(onMouseDown);
        MouseUp+=new System.Windows.Forms.MouseEventHandler(onMouseUp);
    }

     public void OnPaint(object sender, PaintEventArgs e){
    }

    public void onMouseDown(object sender, MouseEventArgs e){

       startPoint=new Nilesh.Drawing.Point(e.X, e.Y);
    }
     public void onMouseUp(object sender, MouseEventArgs e){
        endPoint=new Nilesh.Drawing.Point(e.X, e.Y);
        Line l=new Line(startPoint, endPoint, 3, "red");
        Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0));
        Graphics g=this.CreateGraphics();
        g.DrawLine(pen,l.StartPoint.X, l.StartPoint.Y, l.EndPoint.X, l.EndPoint.Y);
    }
}
