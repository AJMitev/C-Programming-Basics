using System;

class TreatedPatients
{
    static void Main()
    {
        //Input
        int days = int.Parse(Console.ReadLine());

        //Logic
        int doctors = 7;
        int patients = 0;
        int treatedPatiets = 0;
        int untreatedPatients = 0;
        int moreDoctors = 0;
        for (int i = 1; i <= days; i++)
        {
            if (i % 3 == 0 && untreatedPatients > treatedPatiets)
            {
                doctors++;
            }
            patients = int.Parse(Console.ReadLine());
            moreDoctors = doctors - patients;
            if (moreDoctors < 0)
            {
                untreatedPatients += Math.Abs(moreDoctors);
                treatedPatiets += doctors;
            }
            else treatedPatiets += patients;
            


        }

        //Output
        Console.WriteLine($"Treated patients: {treatedPatiets}.\nUntreated patients: {untreatedPatients}.");
    }

}
