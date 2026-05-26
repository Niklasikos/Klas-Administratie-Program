namespace Klasadministratie;

public class SchoolClass
{
    public string? className {get; set;}
    public int? classyear {get; set;}
    public List<Student?> studentenInClass {get; set;} = new List<Student?>();
    public SchoolClass(string? className, int? classyear, List<Student> students)
    {
        this.className = className;
        this.classyear = classyear;
        foreach (Student student in students)
        {
            studentenInClass.Add(student);
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("=========================================================");
        Console.WriteLine($"Class Naam: {className}");
        Console.WriteLine($"Class Jaar: {classyear}");
        Console.WriteLine($"Aantal Studenten: {studentenInClass.Count}");
        foreach (Student student in studentenInClass)
        {
            student.DisplayInfoShort();
        }
        Console.WriteLine("=========================================================");
    }

    public void RemoveStudent(Student? student)
    {
        if (student == studentenInClass.Find(studentenInClass => studentenInClass.studentNumber == student.studentNumber))
        {
            studentenInClass.Remove(student);
            Console.WriteLine("Student verwijdert.");
        }
        else if (student != studentenInClass.Find(studentenInClass => studentenInClass.studentNumber == student.studentNumber))
        {
            Console.WriteLine("Student zit niet in deze Class");
        }
    }

    public void AddStudent(Student? student)
    {
        if (student == studentenInClass.Find(studentenInClass => studentenInClass.studentNumber == student.studentNumber))
        {
            Console.WriteLine("Student zit al in deze Class. Aub afbreken of andere Student nummer gebruiken.");
        }
        if (student != studentenInClass.Find(studentenInClass => studentenInClass.studentNumber == student.studentNumber))
        {
            studentenInClass.Add(student);
            Console.WriteLine("Student Bijgevoegd");
        }
    }
}