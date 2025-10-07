using veterinary_Clinic.Models;

Patients patient1 = new Patients()
{
    Name = "Buddy",
    Age = "3 years",
    Symptoms = "Coughing and sneezing"
};


Console.WriteLine($"Patient Name: {patient1.Name}");
Console.WriteLine($"Age: {patient1.Age}");
Console.WriteLine($"Symptoms: {patient1.Symptoms}");