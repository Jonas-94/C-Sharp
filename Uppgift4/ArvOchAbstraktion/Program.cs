using System;
using Klasser;

namespace ArvOchAbstraktion
{
    public class Program
    {
        static  IVerkstad verkstad;


       

        static void Main(string[] args)
        {
            chosevverkstad();


        }
        public static void chosevverkstad()
        {

            Console.WriteLine("välj verkstad. Verkstad[1] Verkstad 2[2] Avsluta program[3]");
            int svar = Convert.ToInt32(Console.ReadLine());
            switch (svar)
            {
                case 1:
                    Console.WriteLine("Välkommen verkstad 1");
                    verkstad = new Verkstad();
                    Enterverkstad();
                    break;
                case 2:
                    Console.WriteLine("Välkommen till verkstad 2");
                    verkstad = new Verkstadv2();
                    Enterverkstad();
                    break;
                case 3:

                    break;

            }
        }
        public static void Enterverkstad()
        {


            bool program = true;
            while (program)
            {
                Console.WriteLine($" Välj ett alternativ?" +
                $"\n [1] Vill du ta bort ett fordon?" +
                $"\n [2] Vill du lägga till ett fordon?" +
                $"\n [3] Kolla igenom fordon i verkstad" +
                $"\n [4] Avsluta program");
                int svar1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (svar1)
                {
                    case 1:
                        Hämtafordon();
                        break;
                    case 2:
                        Lämnafordon();
                        break;
                    case 3:

                        verkstad.VisaFordon();
                        break;
                    case 4:
                        program = false;
                        chosevverkstad();
                        break;



                }

            }


        }
        public static void Lämnafordon()
        {
              
        Console.WriteLine($"Vilket typ av fordon vill du lämna in?:" +
                $"\n[1]Bil " +
                $"\n[2]Buss" +
                $"\n[3]Motorcykel" +
                $"\n[4]Lastbil");




            int svar1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (svar1)
            {
                case 1:
                    Bil bil = new Bil();
                    Console.Write("Modell?: ");
                    bil._Modellnamn = Console.ReadLine();
                    Console.Write("Registreringsnummer?: ");
                    bil._Regnummer = Console.ReadLine();
                    bil._Registrering = DateTime.Now;
                    Console.Write("Dragkrok? ja/nej: ");
                    string dragkrok = Console.ReadLine();

                    if (dragkrok == "ja")
                    {
                        bil._Dragkrok = true;
                        Console.WriteLine("Bilen har dragkrok");
                    }
                    else if (dragkrok == "nej")
                    {
                        bil._Dragkrok = false;
                    }
                    verkstad.bilar.Add(bil);
                    verkstad.Addfordon(bil);
                    break;

                case 2:
                    Buss buss = new Buss();
                    Console.Write("Modell?: ");
                    buss._Modellnamn = Console.ReadLine();
                    Console.Write("Registreringsnummer?: ");
                    buss._Regnummer = Console.ReadLine();
                    buss._Registrering = DateTime.Now;
                    Console.Write("Hur många passagerare rymmer bussen?: ");
                    int passagerare = Convert.ToInt32(Console.ReadLine());
                    buss._Maxantalpassagerare = passagerare;
                    verkstad.bussar.Add(buss);
                    verkstad.Addfordon(buss);
                    break;

                case 3:
                    Motorcykel motorcykel = new Motorcykel();
                    Console.Write("Modell?: ");
                    motorcykel._Modellnamn = Console.ReadLine();
                    Console.Write("Registreringsnummer?: ");
                    motorcykel._Regnummer = Console.ReadLine();
                    motorcykel._Registrering = DateTime.Now;
                    Console.Write("Maxfart?: ");
                    motorcykel._Maxfart = Convert.ToInt32(Console.ReadLine());
                    if (motorcykel._Maxfart > 200 && verkstad.GetType().Name == "Verkstad")
                    {
                        Console.WriteLine("Den här åker för fort för verkstad 1, lägg in den i verkstad två istället.");
                        chosevverkstad();
                    }
                    else
                    {

                        verkstad.motorcyklar.Add(motorcykel);
                        verkstad.Addfordon(motorcykel);
                    }
                    break;

                case 4:
                    Lastbil lastbil = new Lastbil();
                    Console.Write("Modell?: ");
                    lastbil._Modellnamn = Console.ReadLine();
                    Console.Write("Registreringsnummer?: ");
                    lastbil._Regnummer = Console.ReadLine();
                    lastbil._Registrering = DateTime.Now;
                    Console.Write("Maxlast?: ");
                    lastbil._Maxlastikg = Convert.ToInt32(Console.ReadLine());
                    if (lastbil._Maxlastikg > 200 && verkstad.GetType().Name == "Verkstad")
                    {
                        Console.WriteLine("Den här väger för mycket för verkstad 1, lägg in den i verkstad två istället.");
                        chosevverkstad();
                    }
                    else
                    {

                        verkstad.lastbilar.Add(lastbil);
                        verkstad.Addfordon(lastbil);
                    }

                    break;


            }


        }
        public static void Hämtafordon()
        {
            verkstad.VisaFordon();
            Console.WriteLine("Välj ett nummer du vill ta bort:");
            Console.WriteLine("Vill du gå tillbaka till Meny?Skriv siffra 0.");
            int nummer = Convert.ToInt32(Console.ReadLine());


            if (nummer <= verkstad.fordoniverkstad.Count && nummer >= 0)
            {
                if (nummer == 0)
                {
                    Console.Clear();
                    Enterverkstad();

                }
                else
                {
                    Console.WriteLine($"Du har tagit bort:{verkstad.fordoniverkstad[nummer - 1]._Modellnamn} med regnummer:{verkstad.fordoniverkstad[nummer - 1]._Regnummer}");
                    if (verkstad.fordoniverkstad[nummer - 1].GetType().Name == "Bil")
                    {
                        verkstad.bilar.Remove((Bil)verkstad.fordoniverkstad[nummer - 1]);
                    }
                    if (verkstad.fordoniverkstad[nummer - 1].GetType().Name == "Motorcykel")
                    {
                        verkstad.motorcyklar.Remove((Motorcykel)verkstad.fordoniverkstad[nummer - 1]);
                    }
                    if (verkstad.fordoniverkstad[nummer - 1].GetType().Name == "Lastbil")
                    {
                        verkstad.lastbilar.Remove((Lastbil)verkstad.fordoniverkstad[nummer - 1]);
                    }
                    if (verkstad.fordoniverkstad[nummer - 1].GetType().Name == "Buss")
                    {
                        verkstad.bussar.Remove((Buss)verkstad.fordoniverkstad[nummer - 1]);
                    }
                    verkstad.Deletefordon(verkstad.fordoniverkstad[nummer - 1]);
                }



            }
            else
            {
                Console.WriteLine("Inte rätt svarsallternativ:(");
                Hämtafordon();
            }
        }
    }
}

