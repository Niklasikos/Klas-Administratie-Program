namespace Klasadministratie;

internal class SchoolClass
{
    public string? className {get; set;}
    public int? classyear {get; set;}
    public List<Student> studentenInClass = new List<Student>();
    internal SchoolClass(string? className, int? classyear, List<Student> students)
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

    public void RemoveStudent(int studentNumberAdd)
    {
        Student student = studentenInClass.Find(studentenInClass => studentenInClass.studentNumber == studentNumberAdd);
        studentenInClass.Remove(student);
    }

    public void AddStudent(Student student)
    {
        if (student == studentenInClass.Find(studentenInClass => studentenInClass.studentNumber == student.studentNumber))
        {
            Console.WriteLine("Student al in deze Class. Aub afbreken of andere Student nummer gebruiken.");
        }
        if (student != studentenInClass.Find(studentenInClass => studentenInClass.studentNumber == student.studentNumber))
        {
            studentenInClass.Add(student);
            Console.WriteLine("Student Bijgevoegd");
        }
    }
}