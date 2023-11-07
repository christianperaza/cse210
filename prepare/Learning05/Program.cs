using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square square = new Square("Blue", 4);
        Rectangle rectangle = new Rectangle("Red", 5, 5);
        Circle circle = new Circle("Yellow", 2);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"{color} shape's area: {area}.");
        }

    }
}