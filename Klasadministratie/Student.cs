namespace Klasadministratie;

internal class Student
{
    public int studentNumber { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }

    public Student(int studentNumber, string firstName, string lastName, int age)
    {
        this.studentNumber = studentNumber;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student Number : {studentNumber}");
        Console.WriteLine($"Student First Name: {firstName}");
        Console.WriteLine($"Student Last Name: {lastName}");
        Console.WriteLine($"Student age: {age}");
    }
}
