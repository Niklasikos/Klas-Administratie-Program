namespace Klasadministratie;

internal class SchoolClass
{
    public string className {get; set;}
    public int? classyear {get; set;}
    public List<Student> studentenInClass = new List<Student>();
    internal SchoolClass(string className, int classyear, List<Student> students)
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
        
        Console.WriteLine("=========================================================");
    }

    public void RemoveStudent(int studentNumberAdd)
    {
        Student student = studentenInClass.Find(studentenInClass => studentenInClass.studentNumber == studentNumberAdd);
        studentenInClass.Remove(student);
    }

    public void AddStudent(Student student)
    {
        studentenInClass.Add(student);
    }
}