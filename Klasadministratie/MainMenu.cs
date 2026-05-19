namespace Klasadministratie;

internal class MainMenu
{
    public MainMenu()
    {
        Console.WriteLine("====================Klas Adminisratie====================");
        Console.WriteLine("Kies een van de opties 1-12:");
        Console.WriteLine("1: Student Bijvoegen");
        Console.WriteLine("2: Student Zoeken met Nummer");
        Console.WriteLine("3: Student info aanpassen");
        Console.WriteLine("4: Klas Bijvoegen");
        Console.WriteLine("5: Klas Zoeken met Nummer");
        Console.WriteLine("6: Klas info aanpassen");
        Console.WriteLine("7: Docent Bijvoegen");
        Console.WriteLine("8: Docent Zoeken met Nummer");
        Console.WriteLine("9: Docent info aanpassen");
        Console.WriteLine("10: Les Bijvoegen");
        Console.WriteLine("11: Les Zoeken met Nummer");
        Console.WriteLine("12: Les info aanpassen");
        Console.WriteLine("=========================================================");        
        string? inputstring = Console.ReadLine();
        int input = int.Parse(inputstring);
        switch(input)
        {
            case 1:
                //functie
            break;

            case 2:
                //functie
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

    public void CreateStudent()
    {
        Student student0 = new Student(1001, "jeff", "geerling", 19);
        student0.DisplayInfo();
    }

}
