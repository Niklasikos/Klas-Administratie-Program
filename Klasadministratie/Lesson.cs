namespace Klasadministratie;

public class Lesson
{
    public int? lessonNumber {get; set;}
    public string? subject {get; set;}
    public SchoolClass? schoolClass {get; set;}
    public Teacher? teacher {get; set;}
    public string? classRoom {get; set;}
    public string? startTime {get; set;}
    public string? day {get; set;}
    public Lesson(string? subject, SchoolClass? schoolClass, Teacher? teacher, string? classRoom, string? startTime, string? day, int? lessonNumber)
    {
        this.lessonNumber = lessonNumber;
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
        Console.WriteLine($"{day} {startTime} | {subject} | {schoolClass.className} | {teacher.familyName} | {classRoom} | {lessonNumber}");
        Console.WriteLine("=========================================================");
    }
}