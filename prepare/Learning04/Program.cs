using System;

class Program
{
    static void Main(string[] args)
    {

        // ------------ NAME ATTRIBUTE ------------ //
        string name = "Christian Peraza"; // Variable to store the student name



        // ------------ MATH ASSIGNMENT ------------ //
        string mathTopic = "Fractions"; // Variable to store the Math Topic
        string textbookSection = "7.3"; // Variable to store the Book Section
        string problems = "8-19"; // Variable to store the Problems

        MathAssignment mathAssignment = new MathAssignment(textbookSection, problems, name, mathTopic); // Instance for MathAssignment class with all the information setted

        string mathSummary = mathAssignment.GetSummary(); // Call the GetSummary method and store it into a variable
        string homeworkList = mathAssignment.GetHomeworkList(); // Call the GetHomeworkList method and store it into a variable

        Console.WriteLine("--------------------------------------"); // A design
        Console.WriteLine(mathSummary); // Print the Math Summary
        Console.WriteLine(homeworkList); // Print the Homework List



        // ------------ WRITING ASSIGNMENT ------------ //
        string writingTopic = "European History"; // Variable to store the Writing Topic
        string writingTitle = "The Causes of World War II"; // Variable to store the Book Title
        
        WritingAssignment writingAssignment = new WritingAssignment(writingTitle, name, writingTopic); // Instance for WritingAssignment class with all the information setted

        string writingSummary = writingAssignment.GetSummary(); // Call the GetSummary method and store it into a variable
        string writingInformation = writingAssignment.GetWritingInformation(); // Call the GetWritingInformation method and store it into a variable
        string writingStudentName = writingAssignment.GetStudentName(); // Call the GetStudentName from Assignment class method and store it into a variable

        Console.WriteLine(""); // A line space

        Console.WriteLine(writingSummary); // Print the Writing Summary
        Console.Write(writingInformation); // Print the Writing Information
        Console.WriteLine(writingStudentName); // Print the student name
        Console.WriteLine("--------------------------------------"); // A design

    }
}