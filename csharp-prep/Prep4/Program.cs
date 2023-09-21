using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int userNumber;

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Give me some numbers (Type 0 to stop):");
        Console.WriteLine("");

        List<int> numbers = new List<int>();

        // This next loop will stop when the user enters 0
        do {
            
            // Ask the user for a series of numbers
            Console.Write("Enter number: ");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            // And append each one to a list
            numbers.Add(userNumber);

        } while (userNumber > 0);

        // Compute the sum, or total, of the numbers in the list
        int total = numbers.Sum();

        // Compute the average of the numbers in the list
        // I used "RemoveAt" method because I don't want to count the number "0" (the last number) into the average
        numbers.RemoveAt(numbers.Count - 1);
        double average = numbers.Average();

        // Find the maximum, or largest, number in the list
        int largestNumber = numbers.Max();

        Console.WriteLine($"Total: {total}.");
        Console.WriteLine($"Average: {average}.");
        Console.WriteLine($"Largest number: {largestNumber}.");

        Console.WriteLine("----------------------------------------------");
        
    }
}