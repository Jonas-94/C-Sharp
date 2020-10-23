using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Logic.Entities
{
    class Verkstad
    {
        List<Fordon> fordoniverkstad = new List<Fordon>();
        
        public void Registrerafordon()
        {
            Console.WriteLine("Vilket fordon vill du lägga till? [1]Bil [2]Lastbil [3]Buss [4]Motorcykel ");
            int answer = Convert.ToInt32(Console.ReadLine());
            
            switch (answer)
            {
                case 1:
                    Bil bil = new Bil();
                    Console.Write("Modell på fordon?: ");
                    bil.Modellnamn = Console.ReadLine();
                    Console.Write("Registreringsnummer?: ");
                    bil.Registreringsnummer = Console.ReadLine();
                    Console.Write("Mil bilen åkt?: ");
                    bil.Milmätare = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Bilen registrerades?: ");
                    bil.Registreringsdatum = Console.ReadLine();
                    Console.Write("Typ av drivmedel? Bensin, El, Diesel, Etanol: ");
                    bil.Drivmedel = Console.ReadLine();
                    Console.Write("Dragkrok? j/n:");
                    string svar = Console.ReadLine();
                    if (svar == "j")
                    {
                        bil.Dragkrok = true;
                    }
                    else
                    {
                        bil.Dragkrok = false;
                    }
                    
                    fordoniverkstad.Add(bil);
                    break;
                case 2:
                    Fordon lastbil = new Fordon();
                    Console.Write("Modell på fordon?: ");
                    lastbil.Modellnamn = Console.ReadLine();
                    Console.Write("Registreringsnummer?: ");
                    lastbil.Registreringsnummer = Console.ReadLine();
                    Console.Write("Mil bilen åkt?: ");
                    lastbil.Milmätare = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Bilen registrerades?: ");
                    lastbil.Registreringsdatum = Console.ReadLine();
                    Console.Write("Typ av drivmedel? Bensin, El, Diesel, Etanol: ");
                    lastbil.Drivmedel = Console.ReadLine();
                    fordoniverkstad.Add(lastbil);

                    break;
                case 3:
                    Fordon buss = new Fordon();
                    Console.Write("Modell på fordon?: ");
                    buss.Modellnamn = Console.ReadLine();
                    Console.Write("Registreringsnummer?: ");
                    buss.Registreringsnummer = Console.ReadLine();
                    Console.Write("Mil bilen åkt?: ");
                    buss.Milmätare = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Bilen registrerades?: ");
                    buss.Registreringsdatum = Console.ReadLine();
                    Console.Write("Typ av drivmedel? Bensin, El, Diesel, Etanol: ");
                    buss.Drivmedel = Console.ReadLine();
                    fordoniverkstad.Add(buss);
                    break;
                case 4:
                    Fordon motorcykel = new Fordon();
                    Console.Write("Modell på fordon?: ");
                    motorcykel.Modellnamn = Console.ReadLine();
                    Console.Write("Registreringsnummer?: ");
                    motorcykel.Registreringsnummer = Console.ReadLine();
                    Console.Write("Mil bilen åkt?: ");
                    motorcykel.Milmätare = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Bilen registrerades?: ");
                    motorcykel.Registreringsdatum = Console.ReadLine();
                    Console.Write("Typ av drivmedel? Bensin, El, Diesel, Etanol: ");
                    motorcykel.Drivmedel = Console.ReadLine();
                    fordoniverkstad.Add(motorcykel);
                    break;
                    
            }
        }
    }
}
