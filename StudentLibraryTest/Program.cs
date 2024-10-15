using StudentLibrary; // Reference to StudentLibrary
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two student objects
        Student student1 = new Student("John Smith", 18);
        Student student2 = new Student("Alice Johnson", 20);

        // Display details for both students
        Console.WriteLine("Before getting older:");
        student1.Display(); // Display student1 details
        student2.Display(); // Display student2 details

        // Call GetOlder on both students
        student1.GetOlder();
        student2.GetOlder();

        // Display updated details for both students
        Console.WriteLine("\nAfter getting older:");
        student1.Display(); // Display updated student1 details
        student2.Display(); // Display updated student2 details

        // Keep the console window open
        Console.ReadKey();
    }
}
