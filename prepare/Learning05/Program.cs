using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square square = new Square("blue", 4);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

    }
}