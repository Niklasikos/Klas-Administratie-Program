namespace Klasadministratie;

internal class MainMenu
{
    public int studentNumberLine = 1000;
    List<Student> students = new List<Student>();
    public MainMenu()
    {
        MainMenuText();
    }

    public void MainMenuText()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White; // color changer font
        Console.WriteLine("====================Klas Adminisratie====================");
        Console.WriteLine("Kies een van de opties 1-12:");
        Console.WriteLine("1: Student Bijvoegen");
        Console.WriteLine("2: Student Lijst tonen");
        Console.WriteLine("3: Student info aanpassen");
        Console.WriteLine("4: Klas Bijvoegen");
        Console.WriteLine("5: Klas Lijst tonen");
        Console.WriteLine("6: Klas info aanpassen");
        Console.WriteLine("7: Docent Bijvoegen");
        Console.WriteLine("8: Docent Lijst tonen");
        Console.WriteLine("9: Docent info aanpassen");
        Console.WriteLine("10: Les Bijvoegen");
        Console.WriteLine("11: Les Lijst tonen");
        Console.WriteLine("12: Les info aanpassen");
        Console.WriteLine("=========================================================");   
        string? inputstring = Console.ReadLine();
        int input = int.Parse(inputstring);
        switch(input)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Voornaam Student:");
                string? firstName = Console.ReadLine();
                Console.WriteLine("Familie naam Student:");
                string? lastName = Console.ReadLine();
                Console.WriteLine("Leeftijd Student:");
                string? agestring = Console.ReadLine();
                int age = int.Parse(agestring);
                Student student = new Student(studentNumberLine, firstName, lastName, age);
                studentNumberLine++;
                students.Add(student);
                student.DisplayInfo();
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                MainMenuText();
            break;

            case 2:
                Console.Clear();
                foreach (Student students in students)
                {
                    Console.WriteLine("=========================================================");   
                    students.DisplayInfo();
                    Console.WriteLine("=========================================================");   
                }
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                MainMenuText();
            break;

            case 3:
                //functie
            break;

            case 4:
                //functie
            break;

            default:
                // als het een andere getaal is
            break;
        }
    }
}
