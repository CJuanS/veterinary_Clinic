
namespace veterinary_Clinic.Models;

public class Patient
{

    public Guid ID { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Symptoms { get; set; }


    public Patient(string NamePatient, int AgePatient, string SymptomsPatient)
    {
        ID = Guid.NewGuid();
        Name = NamePatient;
        Age = AgePatient;
        Symptoms = SymptomsPatient;
    }

        public void ShowInformation()
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Symptoms: {Symptoms}");
        Console.WriteLine("---------------------------");
    }
    
    
    
}


