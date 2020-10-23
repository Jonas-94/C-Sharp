using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using Klasser;

namespace ArvOchAbstraktion
{
    public class Verkstad: IVerkstad
    {
        
        List<Fordon> fordonslista = new List<Fordon>();

        public void Läggtill()
        {
            Console.WriteLine("Vilken fordon vill du lägga till?  [1]Bil [2]Lastbil [3]Buss [4]Motorcykel");
            int svar = Convert.ToInt32(Console.ReadLine());
            switch (svar)
            {
                case 1:
                    Fordon bil = new Fordon();
                    Console.WriteLine("Modellnamn?: ");
                    bil._Modellnamn = Console.ReadLine();
                    Console.WriteLine("Registreringsnummer?: ");
                    bil._Regnummer = Console.ReadLine();
                    Console.WriteLine("Hur många mill har bilen åkt?: ");
                    bil._Milmätare = Convert.ToDouble(Console.ReadLine());
                    bil._Registrering = DateTime.Now;
                    Addfordon(bil);
                    break;
                case 2:
                    Fordon lastbil = new Fordon();
                    Console.WriteLine("Modellnamn?: ");
                    lastbil._Modellnamn = Console.ReadLine();
                    Console.WriteLine("Registreringsnummer?: ");
                    lastbil._Regnummer = Console.ReadLine();
                    Console.WriteLine("Hur många mill har bilen åkt?: ");
                    lastbil._Milmätare = Convert.ToDouble(Console.ReadLine());
                    lastbil._Registrering = DateTime.Now;
                    Addfordon(lastbil);
                    break;
                case 3:
                    Fordon buss = new Fordon();
                    Console.WriteLine("Modellnamn?: ");
                    buss._Modellnamn = Console.ReadLine();
                    Console.WriteLine("Registreringsnummer?: ");
                    buss._Regnummer = Console.ReadLine();
                    Console.WriteLine("Hur många mill har bilen åkt?: ");
                    buss._Milmätare = Convert.ToDouble(Console.ReadLine());
                    buss._Registrering = DateTime.Now;
                    Addfordon(buss);
                    break;
                case 4:
                    Fordon motorcykel = new Fordon();
                    Console.WriteLine("Modellnamn?: ");
                    motorcykel._Modellnamn = Console.ReadLine();
                    Console.WriteLine("Registreringsnummer?: ");
                    motorcykel._Regnummer = Console.ReadLine();
                    Console.WriteLine("Hur många mill har bilen åkt?: ");
                    motorcykel._Milmätare = Convert.ToDouble(Console.ReadLine());
                    motorcykel._Registrering = DateTime.Now;
                    Addfordon(motorcykel);
                    break;

            }

        }
        public void Addfordon(Fordon fordon)
        {
            fordonslista.Add(fordon);
            
        }

        public void Deletefordon(Fordon fordon)
        {
            fordonslista.Remove(fordon);
        }


    }
}


//{
//    string regnummer = Console.ReadLine().ToUpper();
//    Fordon tabortbil = null;
//    foreach (var f in fordoniverkstad)
//    {

//        if (regnummer == f._Regnummer)
//        {

//            tabortbil = f;
//        }
//    }
//    if (tabortbil != null)
//    {

//    fordoniverkstad.Remove(tabortbil);
//        Console.WriteLine($" Fordon med regnummer {regnummer} har tagits bort från verkstaden ");
//    }
//    else  
//    {
//        Console.WriteLine($"Ett fordon med regnummer {regnummer} hittades inte");
//    }
//}




