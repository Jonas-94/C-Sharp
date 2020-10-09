using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    public class Verkstadv2 : IVerkstad
    {
        public List<Fordon> fordoniverkstad { get; set; } = new List<Fordon>();
        public List<Bil> bilar { get; set; } = new List<Bil>();
        public List<Lastbil> lastbilar { get; set; } = new List<Lastbil>();
        public List<Motorcykel> motorcyklar { get; set; } = new List<Motorcykel>();
        public List<Buss> bussar { get; set; } = new List<Buss>();



        public void Addfordon(Fordon fordon)
        {
            fordoniverkstad.Add(fordon);
            Console.WriteLine($"Vi har lagt till en {fordon.GetType().Name}");

        }

        public void Deletefordon(Fordon fordon)
        {
            fordoniverkstad.Remove(fordon);
            Console.WriteLine($"Vi har tagit bort en {fordon.GetType().Name}");
        }
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
    }


}


