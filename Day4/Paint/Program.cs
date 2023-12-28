using Nilesh.Drawing;

namespace Paint;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
       Line l = new Line();
         l.Color="Red";
        l.width=2;
        l.Draw();
        //l.StartPoint=new Graphics.Point(34,45);
        //l.EndPoint=new Graphics.Point(67,100);
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}