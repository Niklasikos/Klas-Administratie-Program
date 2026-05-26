namespace Klasadministratie;

public class Lesson
{
    public string? subject;
    internal SchoolClass? schoolClass;
    internal Teacher? teacher;
    public string? classRoom;
    public string? startTime;
    public string? day;
    public Lesson(string? subject, SchoolClass? schoolClass, Teacher? teacher, string? classRoom, string? startTime, string? day)
    {
        this.subject = subject;
        this.schoolClass = schoolClass;
        this.teacher = teacher;
        this.classRoom = classRoom;
        this.startTime = startTime;
        this.day = day;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("=========================================================");
        Console.WriteLine($"{day} {startTime} | {subject} | {schoolClass.className} | {teacher.familyName} | {classRoom}");
        Console.WriteLine("=========================================================");
    }
}