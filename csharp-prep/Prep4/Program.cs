using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int userNumber;

        Console.WriteLine("Give me some numbers (Type 0 to stop):");

        List<int> numbers = new List<int>();

        do {

            Console.Write("Enter number: ");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            numbers.Add(userNumber);

        } while (userNumber > 0);

        int total = numbers.Sum();

        numbers.RemoveAt(numbers.Count - 1);
        double average = numbers.Average();

        int largestNumber = numbers.Max();

        Console.WriteLine($"Total: {total}.");
        Console.WriteLine($"Average: {average}.");
        Console.WriteLine($"Largest number: {largestNumber}.");
        

    
    }
}