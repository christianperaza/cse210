using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction fractionNoParameters = new Fraction();
        Fraction fraction1Parameters = new Fraction(6);
        Fraction fraction2Parameters = new Fraction(6, 7);

        Console.WriteLine("");
        // Fraction with no parameters. The total will be 1/1
        fractionNoParameters.GetFractionString();
        fractionNoParameters.GetDecimalValue();
        Console.WriteLine("");

        // Fraction with 1 parameter (TOP). The total will be 5/1
        fraction1Parameters.SetTop(5);
        fraction1Parameters.GetFractionString();
        fraction1Parameters.GetDecimalValue();
        Console.WriteLine("");

        // Fraction with 2 parameters (TOP/BOTTOM). The total will be 3/4
        fraction2Parameters.SetTop(3);
        fraction2Parameters.SetBottom(4);
        fraction2Parameters.GetFractionString();
        fraction2Parameters.GetDecimalValue();
        Console.WriteLine("");

        // Another fraction with 2 parameters (TOP/BOTTOM). The total will be 1/3
        fraction2Parameters.SetTop(1);
        fraction2Parameters.SetBottom(3);
        fraction2Parameters.GetFractionString();
        fraction2Parameters.GetDecimalValue();
        Console.WriteLine("");
    }
}