
namespace veterinary_Clinic.Utils;

internal class MainMenu
{
    public static void Display()
    {
        Console.WriteLine("Welcome to the Veterinary Clinic Management System");
        Console.WriteLine("1. Add Patient");
        Console.WriteLine("2. View Patients");
        Console.WriteLine("3. Search Patient");
        Console.WriteLine("4. Update Patient");
        Console.WriteLine("5. Delete Patient");
        Console.WriteLine("6. Exit");
        Console.Write("Please select an option: ");
    }
}
