namespace Klasadministratie;

internal class MainMenu
{
    public int studentNumberLine = 1000;
    public List<Student> students = new List<Student>();
    public List<SchoolClass> schoolClasses = new List<SchoolClass>();
    public MainMenu()
    {
        MainMenuText();
    }

    public void MainMenuText()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen; // color changer font
        Console.WriteLine("====================Klas Adminisratie====================");
        Console.WriteLine("Kies een van de opties 1-12:");
        Console.WriteLine("1: Student Bijvoegen");
        Console.WriteLine("2: Studenten Lijst tonen");
        Console.WriteLine("3: Student info aanpassen");
        Console.WriteLine("4: Klas Bijvoegen");
        Console.WriteLine("5: Klassen Lijst tonen");
        Console.WriteLine("6: Klas info aanpassen");
        Console.WriteLine("7: Docent Bijvoegen");
        Console.WriteLine("8: Docenten Lijst tonen");
        Console.WriteLine("9: Docent info aanpassen");
        Console.WriteLine("10: Les Bijvoegen");
        Console.WriteLine("11: Lessen Lijst tonen");
        Console.WriteLine("12: Les info aanpassen");
        Console.WriteLine("13: Quit Program");
        Console.WriteLine("=========================================================");   
        string? inputstring = Console.ReadLine();
        int input = int.Parse(inputstring);
        switch(input)
        {
            case 1:
                Case1();
            break;

            case 2:
                Case2();
            break;

            case 3:
                Case3();
            break;

            case 4:
                //functie
            break;

            case 13:
                Case13();
            break;

            default:
                // als het een andere getaal is
            break;
        }
    }

    private void Case1()
    {
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
    }

    private void Case2()
    {
        Console.Clear();
        foreach (Student students in students)
        {
            students.DisplayInfo();
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    private void Case3()
    {
        Console.Clear();
        foreach (Student students in students)
        {
            students.DisplayInfo();
        }
        Console.WriteLine("Student info bewerken. Studenten nummer: ");
        string? stringinput = Console.ReadLine();
        int studentinput = int.Parse(stringinput);
        Student? chosenstudent = students.Find(student => student.studentNumber == studentinput);
        if(chosenstudent != null)
        {
            Console.WriteLine("Welke Optie/Waarde bewerken? 1-4");
            chosenstudent.DisplayInfo();
            Console.WriteLine("1. Voornaam");
            Console.WriteLine("2. Familie naam");
            Console.WriteLine("3. Leeftijd");
            Console.WriteLine("4. Student verwijdern");
            string? inputstring = Console.ReadLine();
            int input = int.Parse(inputstring);
            switch(input)
            {
                case 1:
                    Console.WriteLine("Nieuwe Voornaam Student:");
                    string? nieuweVoornaam = Console.ReadLine();
                    chosenstudent.firstName = nieuweVoornaam;
                    chosenstudent.DisplayInfo();
                break;

                case 2:
                    Console.WriteLine("Nieuwe Familie Naam Student:");
                    string? nieuweFamilieNaam = Console.ReadLine();
                    chosenstudent.firstName = nieuweFamilieNaam;
                    chosenstudent.DisplayInfo();
                break;

                case 3:
                    Console.WriteLine("Nieuwe Leeftijd Student:");
                    string? nieuweLeeftijd = Console.ReadLine();
                    chosenstudent.age = int.Parse(nieuweLeeftijd);
                    chosenstudent.DisplayInfo();
                break;

                case 4:
                    students.Remove(chosenstudent);
                    Console.WriteLine("Student Verwijdert");
                break;

                default:
                    Console.WriteLine("ongeldige input");
                break;
            }
        }
        else
        {
            Console.WriteLine("Student niet gevonden.");
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case4()
    { //classes class
        Console.Clear();
        Console.WriteLine("Naam Class:");
        string? firstName = Console.ReadLine();
        Console.WriteLine("Jaar Class:");
        string? lastName = Console.ReadLine();
        Console.WriteLine("Student nummer:");
        string? agestring = Console.ReadLine();
        int age = int.Parse(agestring);
        Student student = new Student(studentNumberLine, firstName, lastName, age);
        studentNumberLine++;
        students.Add(student);
        student.DisplayInfo();
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case13()
    {
        Environment.Exit(0);
    }
}
