using TestJob;

IFigure circle = new Circle(1);
IFigure triangle = new Triangle(3, 4, 5);
var rectangularTriangle = new Triangle(3, 4, 5);

Console.WriteLine(circle.GetArea());
Console.WriteLine(triangle.GetArea());
Console.WriteLine(rectangularTriangle.IsRectangular());
Console.WriteLine(rectangularTriangle.GetArea());