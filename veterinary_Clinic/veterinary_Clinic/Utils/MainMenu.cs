
using System.ComponentModel.DataAnnotations;
using veterinary_Clinic.Models;

namespace veterinary_Clinic.Utils;

public static class MainMenu
{
    static bool Validator = false;
    public static void Display()
    {
        do
        {
            Menu.Show();
            char input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    PatientManager.AddPatient();
                    break;
                case '2':
                    PatientManager.ViewPatients();
                    break;
                case '3':
                    PatientManager.SearchPatient();
                    break;
                case '4':
                    PatientManager.UpdatePatient();
                    break;
                case '5':
                    Console.WriteLine("Delete Patient selected");
                    break;
                case '6':
                    Console.WriteLine("Exiting the application. Goodbye!");
                    Validator = true;
                    break;
                default:
                    break;
            }

        } while (Validator == false);

    }
}

internal class Menu
{
    public static void Show()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Veterinary Clinic Management System");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Add Patient");
        Console.WriteLine("2. View Patients");
        Console.WriteLine("3. Search Patient");
        Console.WriteLine("4. Update Patient");
        Console.WriteLine("5. Delete Patient");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice (1-6): ");
    }
}



