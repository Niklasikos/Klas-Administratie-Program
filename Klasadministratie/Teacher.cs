namespace Klasadministratie;
public class Teacher
{
    // public List<string> subjects = new List<string>(); // zou een te groot brainfuck worden dat te doen is dan bij Lessons een textfeld
    public string? firstName;
    public string? familyName;
    public int? age;
    public Teacher(string? firstName, string? familyName, int? age)
    {
        this.firstName = firstName;
        this.familyName = familyName;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("=========================================================");
        Console.WriteLine($"Docent Voornaam: {firstName}");
        Console.WriteLine($"Docent Familie Naam: {familyName}");
        Console.WriteLine($"Docent Leeftijd: {age}");
        Console.WriteLine("=========================================================");
    }
}