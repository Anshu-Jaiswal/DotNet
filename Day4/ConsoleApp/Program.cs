
using Hardware;
using Nilesh.Drawing;
using System.Collections.Generic;

HPPrinter printer = new HPPrinter();
printer.Print();
printer.Scan();

List<Shape> shapes = new List<Shape>();
Line l = new Line();
l.StartPoint = new Point(34,45);
l.EndPoint = new Point(70,100);
l.Color="Red";
l.width=2;
Point center = new Point(50,70);

Circle c=new Circle(center, 15, 3, "blue");
c.Draw();

Console.WriteLine(l);
shapes.Add(l);
shapes.Add(c);

foreach(Shape s in shapes){
    Console.WriteLine(s);
}