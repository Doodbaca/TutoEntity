using System;

namespace TutoEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVaccin pfizer = new TypeVaccin { Nom = "Pfizer"}; 
            TypeVaccin moderna = new TypeVaccin { Nom = "Moderna"}; 
            Vaccin dose1Mylene = new Vaccin { Date = DateTime.Today,NAMPatient = "LAPM12345678",Type = moderna}; 
            Vaccin dose1Gaston = new Vaccin { Date = new DateTime(2021, 01, 15),NAMPatient = "BHEG12345678",Type = pfizer}; 
            VaccinContext context = new VaccinContext(); 
            context.Vaccins.Add(dose1Mylene);
            context.Vaccins.Add(dose1Gaston);
            context.SaveChanges(); context.Remove(dose1Gaston);
            dose1Mylene.Type = pfizer; 
            context.SaveChanges();
            foreach (Vaccin vaccin in context.Vaccins) Console.WriteLine(vaccin);
        }
    }
}
