using System;

class Program
{
    static void Main(string[] args)
    {
        // This next line is just design
        Console.WriteLine("-------------------------------------");

        // Ask user his grade percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        // Change user input to integer number
        int gradePercentage = int.Parse(userInput);

        // This next line is just a space
        Console.WriteLine("");

        // A string variable to store the letter grade
        string letter = "";

        // Conditions to know what letter corresponds to the grade percentage
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // An integer number variable to store the last digit of the grade percentage number
        int lastDigit = gradePercentage % 10;
        // An string variable to store the sign + or -
        string sign = "";

        // Conditions to know what sign (+ or -) corresponds to the letter grade
        if (lastDigit >= 7 && gradePercentage < 90 && gradePercentage > 59)
        {
            sign = "+";
        }
        else if (lastDigit < 3 && gradePercentage > 59)
        {
            sign = "-";
        }

        // Conditions to know what message corresponds to the grade percentage
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulation! You have passed the class with '{letter}{sign}' grade.");
        }
        else
        {
            Console.WriteLine($"I'm sorry. You have not passed the class with '{letter}{sign}' grade. Don't worry. You will do it better next time!");
        }

        // This next line is just design
        Console.WriteLine("-------------------------------------");
    }
}