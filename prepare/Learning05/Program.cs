using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square square = new Square("blue", 4);
        Rectangle rectangle = new Rectangle("red", 5, 5);
        Circle circle = new Circle("yellow", 2);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine(color);
            Console.WriteLine(area);
        }

    }
}