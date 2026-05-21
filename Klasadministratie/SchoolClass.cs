namespace Klasadministratie;

internal class SchoolClass
{
    public string className {get; set;}
    public int classyear {get; set;}
    public List<Student> studentenInClass = new List<Student>();
    internal SchoolClass(string className, int classyear, Student student)
    {
        this.className = className;
        this.classyear = classyear;
        studentenInClass.Add(student);
    }

    public void DisplayInfo()
    {
        Console.WriteLine("=========================================================");
        
        Console.WriteLine("=========================================================");
    }
}