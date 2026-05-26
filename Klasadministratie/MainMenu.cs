namespace Klasadministratie;

internal class MainMenu // holy Spaghetti code
{
    public int studentNumberLine = 1000;
    public List<Student> students = new List<Student>();
    public List<SchoolClass> schoolClasses = new List<SchoolClass>();
    public List<Lesson> lessons = new List<Lesson>();
    public List<Teacher> teachers = new List<Teacher>();
    public MainMenu()
    {
        MainMenuText();
    }

    public void MainMenuText()
    {
        try
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen; // color changer font
            Console.WriteLine("====================Klas Adminisratie====================");
            Console.WriteLine("Kies een van de opties 1-14:");
            Console.WriteLine("1: Student Bijvoegen");
            Console.WriteLine("2: Studenten Lijst tonen");
            Console.WriteLine("3: Student info aanpassen");
            Console.WriteLine("=========================================================");
            Console.WriteLine("4: Klas Bijvoegen");
            Console.WriteLine("5: Klassen Lijst tonen");
            Console.WriteLine("6: Klas info aanpassen");
            Console.WriteLine("=========================================================");
            Console.WriteLine("7: Docent Bijvoegen");
            Console.WriteLine("8: Docenten Lijst tonen");
            Console.WriteLine("9: Docent info aanpassen");
            Console.WriteLine("=========================================================");
            Console.WriteLine("10: Les Bijvoegen");
            Console.WriteLine("11: Lessen Lijst tonen");
            Console.WriteLine("12: Les info aanpassen");
            Console.WriteLine("=========================================================");
            Console.WriteLine("13: Rooster weergeven");
            Console.WriteLine("14: Quit Program");
            Console.WriteLine("=========================================================");
            string? inputstring = Console.ReadLine();
            int? input = int.Parse(inputstring);
            switch (input)
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
                    Case4();
                    break;

                case 5:
                    Case5();
                    break;

                case 6:
                    Case6();
                    break;

                case 7: 
                    Case7();
                    break;

                case 8:
                    Case8();
                    break;

                case 9:
                    Case9();
                    break;

                case 10:
                    Case10();
                    break;

                case 11:
                    Case11();
                    break;

                case 12: 
                    Case12();
                    break;

                case 13:
                    Case13();
                    break;

                case 14:
                    Case14();
                    break;

                default:
                    Console.WriteLine("Ongeldig Input");
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                    MainMenuText();
                    break;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Geen geldig Input");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            MainMenuText();
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
            students.DisplayInfoShort();
        }
        Console.WriteLine("Student info bewerken. Studenten nummer: ");
        string? stringinput = Console.ReadLine();
        int studentinput = int.Parse(stringinput);
        Student? chosenstudent = students.Find(student => student.studentNumber == studentinput);
        if (chosenstudent != null)
        {
            Console.WriteLine("Welke Optie/Waarde bewerken? 1-4");
            chosenstudent.DisplayInfo();
            Console.WriteLine("1. Voornaam");
            Console.WriteLine("2. Familie naam");
            Console.WriteLine("3. Leeftijd");
            Console.WriteLine("4. Student verwijdern");
            string? inputstring = Console.ReadLine();
            int input = int.Parse(inputstring);
            switch (input)
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
                    Console.WriteLine("Geen geldig input");
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
    {
        Console.Clear();
        Console.WriteLine("Class Naam:");
        string? className = Console.ReadLine();
        Console.WriteLine("Class Jaar:");
        string? classjaarstring = Console.ReadLine();
        int? classjaar = int.Parse(classjaarstring);
        List<Student> studentsToAdd = new List<Student>();
        Console.WriteLine("Studenten al bijvoegen?:");
        Console.WriteLine("1: Ja");
        Console.WriteLine("2: Nee");
        int? studentNumberClass = 1;
        bool Done = false;
        string? inputstring = Console.ReadLine();
        int? inputint = int.Parse(inputstring);
        switch (inputint)
        {
            case 1:
                foreach (Student students in students)
                {
                    students.DisplayInfoShort();
                }
                while (Done == false)
                {
                    Console.WriteLine($"Studenten Nummer van student {studentNumberClass}:");
                    string? studentNumberinput = Console.ReadLine();
                    int? studentNumberInt = int.Parse(studentNumberinput);
                    Student? student = students.Find(students => students.studentNumber == studentNumberInt);
                    if (student == studentsToAdd.Find(studentsToAdd => studentsToAdd.studentNumber == student.studentNumber))
                    {
                        Console.WriteLine("Student al in deze Class. Aub afbreken of andere Student nummer gebruiken.");
                    }
                    if (student != studentsToAdd.Find(studentsToAdd => studentsToAdd.studentNumber == student.studentNumber))
                    {
                        foreach (Student students in studentsToAdd)
                        {
                            student.addedToClass = true;
                        }
                        studentsToAdd.Add(student);
                        Console.WriteLine("Student Bijgevoegd");
                        studentNumberClass++;
                    }
                    Console.WriteLine("Nog meer bijvoegen?");
                    Console.WriteLine("1: Ja");
                    Console.WriteLine("2: Nee");
                    string? NogMeerstring = Console.ReadLine();
                    int? NogMeerint = int.Parse(NogMeerstring);
                    switch (NogMeerint)
                    {
                        case 1:

                            break;
                        case 2:
                            Console.WriteLine("Studenten kunnen later nog bijgevoegd worden");
                            Done = true;
                            break;
                        default:
                            Console.WriteLine("Geen geldig input");
                            break;
                    }
                }

                break;
            case 2:
                Console.WriteLine("Studenten kunnen later nog bijgevoegd worden");
                break;
            default:
                Console.WriteLine("Geen geldig input");
                break;
        }
        SchoolClass schoolClass = new SchoolClass(className, classjaar, studentsToAdd);
        schoolClasses.Add(schoolClass);
        schoolClass.DisplayInfo();
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case5()
    {
        Console.Clear();
        foreach (SchoolClass schoolClass in schoolClasses)
        {
            schoolClass.DisplayInfo();
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case6()
    {
        Console.Clear();
        foreach (SchoolClass schoolClass in schoolClasses)
        {
            schoolClass.DisplayInfo();
        }
        Console.WriteLine("Class info bewerken. Class naam: ");
        string? classinput = Console.ReadLine();
        SchoolClass schoolClassChosen = schoolClasses.Find(schoolClasses => schoolClasses.className == classinput);
        if (schoolClassChosen != null)
        {
            Console.WriteLine("Welke Optie/Waarde bewerken? 1-4");
            schoolClassChosen.DisplayInfo();
            Console.WriteLine("1. Class Naam");
            Console.WriteLine("2. Class Jaar");
            Console.WriteLine("3. Studenten In Class bewerken");
            Console.WriteLine("4. Class verwijdern");
            string? inputstring = Console.ReadLine();
            int? inputint = int.Parse(inputstring);
            switch (inputint)
            {
                case 1:
                    Console.WriteLine("Nieuwe Naam Class:");
                    string? nieuweNaam = Console.ReadLine();
                    schoolClassChosen.className = nieuweNaam;
                    schoolClassChosen.DisplayInfo();
                    break;

                case 2:
                    Console.WriteLine("Nieuw Jaar Class:");
                    string? nieuwJaar = Console.ReadLine();
                    schoolClassChosen.classyear = int.Parse(nieuwJaar);
                    schoolClassChosen.DisplayInfo();
                    break;

                case 3:
                    Console.WriteLine($"Studenten Nummer van student uit/voor {schoolClassChosen.className}:");
                    string? studentNumberinput = Console.ReadLine();
                    int? studentNumberInt = int.Parse(studentNumberinput);
                    Student? student = students.Find(students => students.studentNumber == studentNumberInt);
                    Console.WriteLine("Welke Optie? 1-2");
                    Console.WriteLine("1. Student In Class bijvoegen");
                    Console.WriteLine("2. Student Uit Class verwijdern");
                    string? optieString = Console.ReadLine();
                    int? optieInt = int.Parse(optieString);
                    switch (optieInt)
                    {
                        case 1:
                            if(student.addedToClass == false)
                            {
                                schoolClassChosen.AddStudent(student); 
                                student.addedToClass = true;
                            }
                            else if(student.addedToClass == true)
                            {
                                Console.WriteLine("Student zit al in een class");
                            }
                        break;
                        case 2:
                            schoolClassChosen.RemoveStudent(student);
                            student.addedToClass = false;
                        break;
                        default:
                            Console.WriteLine("Geen geldig input");
                        break;
                    }
                    break;

                case 4:
                    foreach (Student student1 in schoolClassChosen.studentenInClass)
                    {
                        student1.addedToClass = false;
                    }
                    schoolClasses.Remove(schoolClassChosen);
                    Console.WriteLine("Class Verwijdert");
                    break;

                default:
                    Console.WriteLine("Geen geldig input");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Geen geldige Class Naam / Geen Class gevonden");
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case7()
    {
        Console.Clear();
        Console.WriteLine("Voornaam Docent:");
        string? firstName = Console.ReadLine();
        Console.WriteLine("Familie naam Docent:");
        string? lastName = Console.ReadLine();
        Console.WriteLine("Leeftijd Docent:");
        string? agestring = Console.ReadLine();
        int age = int.Parse(agestring);
        Teacher teacher = new Teacher(firstName, lastName, age);
        teachers.Add(teacher);
        teacher.DisplayInfo();
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case8()
    {
        Console.Clear();
        foreach (Teacher teacher in teachers)
        {
            teacher.DisplayInfo();
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case9()
    {
        Console.Clear();
        foreach (Teacher teacher in teachers)
        {
            teacher.DisplayInfo();
        }
        Console.WriteLine("Docent info bewerken. Docent Familie naam: ");
        string? docentInput = Console.ReadLine();
        Teacher teacherchosen = teachers.Find(teachers => teachers.familyName == docentInput);
        if(teacherchosen != null)
        {
            Console.WriteLine("Welke Optie/Waarde bewerken? 1-4");
            teacherchosen.DisplayInfo();
            Console.WriteLine("1. Voornaam");
            Console.WriteLine("2. Familie naam");
            Console.WriteLine("3. Leeftijd");
            Console.WriteLine("4. Docent verwijdern");
            string? inputstring = Console.ReadLine();
            int input = int.Parse(inputstring);
            switch (input)
            {
                case 1:
                    Console.WriteLine("Nieuwe Voornaam Docent:");
                    string? nieuweVoornaam = Console.ReadLine();
                    teacherchosen.firstName = nieuweVoornaam;
                    teacherchosen.DisplayInfo();
                    break;

                case 2:
                    Console.WriteLine("Nieuwe Familie Naam Docent:");
                    string? nieuweFamilieNaam = Console.ReadLine();
                    teacherchosen.firstName = nieuweFamilieNaam;
                    teacherchosen.DisplayInfo();
                    break;

                case 3:
                    Console.WriteLine("Nieuwe Leeftijd Docent:");
                    string? nieuweLeeftijd = Console.ReadLine();
                    teacherchosen.age = int.Parse(nieuweLeeftijd);
                    teacherchosen.DisplayInfo();
                    break;

                case 4:
                    teachers.Remove(teacherchosen);
                    Console.WriteLine("Docent Verwijdert");
                    break;

                default:
                    Console.WriteLine("Geen geldig input");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Geen geldige Docenten Naam / Geen Docent gevonden");
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case10() //
    {
        Console.Clear();
        Console.WriteLine("Vak naam:");
        string? vak = Console.ReadLine();
        foreach (SchoolClass schoolClasses in schoolClasses)
        {
            schoolClasses.DisplayInfo();
        }
        Console.WriteLine("Klas naam:");
        string? className = Console.ReadLine();
        SchoolClass? schoolClass = schoolClasses.Find(schoolClasses => schoolClasses.className == className);
        if(schoolClass != null)
        {
            foreach (Teacher teachers in teachers)
            {
                teachers.DisplayInfo();
            }
            Console.WriteLine("Familie naam Docent:");
            string? familyName = Console.ReadLine();
            Teacher? teacher = teachers.Find(teachers => teachers.familyName == familyName);
            if(teacher != null)
            {
                Console.WriteLine("Lokaal nummer:");
                string? classRoom = Console.ReadLine();
                Console.WriteLine("Begin Tijd (in dit format 00:00): ");
                string? startTime = Console.ReadLine();
                Console.WriteLine("Dag 1-5: ");
                Console.WriteLine("1: Maandag");
                Console.WriteLine("2: Dinsdag");
                Console.WriteLine("3: Woensdag ");
                Console.WriteLine("4: Donderdag ");
                Console.WriteLine("5: Vrijdag ");
                string? inputstring = Console.ReadLine();
                int inputint = int.Parse(inputstring);
                string? day = "Monday";
                switch (inputint)
                {
                    case 1:
                        day = "Maandag";
                        break;

                    case 2:
                        day = "Dinsdag";
                        break;

                    case 3:
                        day = "Woensdag";
                        break;

                    case 4: 
                        day = "Donderdag";
                        break;

                    case 5:
                        day = "Vrijdag";
                        break;

                    default:
                        Console.WriteLine("Geen geldig Input");
                        break;
                }
                Lesson lesson = new Lesson(vak, schoolClass, teacher, classRoom, startTime, day);
                lessons.Add(lesson);
                lesson.DisplayInfo();
            }
            else if(teacher == null)
            {
                Console.WriteLine("Docent niet gevonden");
            }

        }
        else if(schoolClass == null)
        {
            Console.WriteLine("SchoolClass niet gevonden");
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case11()
    {
        Console.Clear();
        foreach (Lesson lesson in lessons)
        {
            lesson.DisplayInfo();
        }
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
        MainMenuText();
    }

    public void Case12()
    {
        
    }

    public void Case13()
    {
        Console.WriteLine("Maandag==================================================");
        foreach (Lesson lesson in lessons)
        {
            if(lesson.day == "Maandag")
            {
                lesson.DisplayInfo();        
            }
        }
        Console.WriteLine("Dinsdag==================================================");
        foreach (Lesson lesson1 in lessons)
        {
            if(lesson1.day == "Dinsdag")
            {
                lesson1.DisplayInfo();
            }
        }
        Console.WriteLine("Woensdag=================================================");
        foreach (Lesson lesson2 in lessons)
        {
            if(lesson2.day == "Woensdag")
            {
                lesson2.DisplayInfo();
            }
        }
        Console.WriteLine("Donderdag================================================");
        foreach (Lesson lesson3 in lessons)
        {
            if(lesson3.day == "Donderdag")
            {
                lesson3.DisplayInfo();
            }
        }
        Console.WriteLine("Vrijdag==================================================");
        foreach (Lesson lesson4 in lessons)
        {
            if(lesson4.day == "Vrijdag")
            {
                lesson4.DisplayInfo();
            }
        }
    }
    public void Case14()
    {
        Environment.Exit(0);
    }
}
