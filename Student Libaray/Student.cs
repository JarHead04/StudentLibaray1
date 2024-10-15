// Student class in StudentLibrary
public class Student
{
    private int id;
    private string name;
    private int age;
    private static int studentCount = 0;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
        id = ++studentCount;
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
    }

    // Method to increase age by 1 and return the new age
    public int GetOlder()
    {
        age += 1;
        return age;
    }
}
