using System.ComponentModel.Design;
using veterinary_Clinic.Models;

public static class PatientManager
{
    private static List<Patient> patients = new List<Patient>();
    public static void AddPatient()
    {
        Console.WriteLine();
        Console.Write("Enter patient name: ");
        string NamePatient = Console.ReadLine().ToLower();
        Console.Write("Enter patient age: ");
        int AgePatient = int.Parse(Console.ReadLine());
        Console.Write("Enter patient symptoms: ");
        string SymptomsPatient = Console.ReadLine();

        patients.Add(new Patient(NamePatient, AgePatient, SymptomsPatient));
        Console.WriteLine("Patient added successfully.");
    }

    public static void ViewPatients()
    {
        if (patients.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("No patients found.");
            return;
        }

        foreach (var patient in patients)
        {
            patient.ShowInformation();
        }
    }
    public static void SearchPatient()
    {
        Console.WriteLine();
        Console.Write("Enter patient name to search: ");
        string searchName = Console.ReadLine().ToLower();
        var foundPatients = patients.Where(p => p.Name != null && p.Name.Contains(searchName)).ToList<Patient>();


        if (foundPatients.Count == 0)
        {
            Console.WriteLine("No patients found with that name.");
            return;
        }
        foreach (var patient in foundPatients)
        {
            patient.ShowInformation();
        }
    }

    public static void UpdatePatient()
    {
        Console.Write("Enter the ID of the user you want to update: ");
        string idInput = Console.ReadLine();
        if (Guid.TryParse(idInput, out Guid patientId))
        {
            var patient = patients.FirstOrDefault(p => p.ID == patientId);
            if (patient != null)
            {
                Console.Write("Enter new name (leave blank to keep current): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    patient.Name = newName;
                }

                Console.Write("Enter new age (leave blank to keep current): ");
                string newAgeInput = Console.ReadLine();
                if (int.TryParse(newAgeInput, out int newAge))
                {
                    patient.Age = newAge;
                }

                Console.Write("Enter new symptoms (leave blank to keep current): ");
                string newSymptoms = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newSymptoms))
                {
                    patient.Symptoms = newSymptoms;
                }

                Console.WriteLine("Patient updated successfully.");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID format.");
        }


    }
}