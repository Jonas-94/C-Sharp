using System;
using System.Collections.Generic;
using Klasser;

namespace ArvOchAbstraktion
{
    public class Program
    {


        Fordon fordon = new Fordon();
        
        
       static List<Fordon> fordonslista = new List<Fordon>();
        static void Main(string[] args)
        {
            int svar1 = Convert.ToInt32(Console.ReadLine());
            switch (svar1)
            {
                case 1:
                    Addfordon();
                    break;
            }


        }

        

        public static void Addfordon()
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
                    fordonslista.Add(bil);
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
                    fordonslista.Add(lastbil);
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
                    fordonslista.Add(buss);
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
                    fordonslista.Add(motorcykel);
                    break;

            }
            
        }
        public static void Visafordon()
        {
            foreach (var f in fordonslista)
            {
                Console.WriteLine($"\n modellnamn: {f._Modellnamn}");
            }
                
            
        }
    }

}

