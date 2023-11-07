using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square square = new Square("blue", 4);
        Rectangle rectangle = new Rectangle("red", 5, 5);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

    }
}