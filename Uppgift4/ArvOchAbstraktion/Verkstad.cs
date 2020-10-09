using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using Klasser;

namespace ArvOchAbstraktion
{
    class Verkstad : IVerkstad
    {
        public List<Fordon> fordoniverkstad { get; set; } = new List<Fordon>();
        public List<Bil> bilar { get; set; } = new List<Bil>();
        public List<Lastbil> lastbilar { get; set; } = new List<Lastbil>();
        public List<Motorcykel> motorcyklar { get; set; } = new List<Motorcykel>();
        public List<Buss> bussar { get; set; } = new List<Buss>();




        public void VisaFordon()
        {


            for (int i = 0; i < fordoniverkstad.Count; i++)
            {


                if (fordoniverkstad[i].GetType().Name == "Bil")
                {
                    Console.WriteLine($"Plats {i + 1}\n-----BILAR-----");
                    for (int p = 0; p < bilar.Count; p++)
                    {
                        if (bilar[p]._Regnummer == fordoniverkstad[i]._Regnummer)
                        {
                            Console.WriteLine($" Har dragkrok: {(bilar[p]._Dragkrok ? "Ja" : "Nej")}");

                        }

                    }
                }
                else if (fordoniverkstad[i].GetType().Name == "Motorcykel")
                {
                    Console.WriteLine($"Plats { i + 1}\n-----Motorcykel-----");
                    for (int p = 0; p < motorcyklar.Count; p++)
                    {
                        if (motorcyklar[p]._Regnummer == fordoniverkstad[i]._Regnummer)
                        {
                            Console.WriteLine($" Maxhastighet: {motorcyklar[p]._Maxfart}");

                        }

                    }
                }
                else if (fordoniverkstad[i].GetType().Name == "Buss")
                {
                    Console.WriteLine($"Plats { i + 1}\n-----Buss-----");
                    for (int p = 0; p < bussar.Count; p++)
                    {
                        if (bussar[p]._Regnummer == fordoniverkstad[i]._Regnummer)
                        {
                            Console.WriteLine($" Max antal passagerare: {bussar[p]._Maxantalpassagerare}");
                        }

                    }
                }
                else if (fordoniverkstad[i].GetType().Name == "Lastbil")
                {
                    Console.WriteLine($"Plats { i + 1}\n-----Lastbil-----");
                    for (int p = 0; p < lastbilar.Count; p++)
                    {
                        if (lastbilar[p]._Regnummer == fordoniverkstad[i]._Regnummer)
                        {
                            Console.WriteLine($" Maxlast: {lastbilar[p]._Maxlastikg}");
                        }

                    }
                }
                Console.WriteLine($"Modell:{fordoniverkstad[i]._Modellnamn} " +
                    $"\n Regnummer: {fordoniverkstad[i]._Regnummer}" +
                    $"\n Datum: {fordoniverkstad[i]._Registrering}");
            }

        }


        public void Addfordon(Fordon fordon)
        {

            fordoniverkstad.Add(fordon);
        }
        public void Deletefordon(Fordon fordon)
        {
            fordoniverkstad.Remove(fordon);
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




