using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Klasser
{
    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // array är bättre om man vet hur många man vill ha från början
           // Bil[] billista2 = {new Bil("Volvo"), new Bil("Jeep"), new Bil("Tesla"), new Bil("Lambo") };
             List<Bil> Billista = new List<Bil>(); 
            
            Bil Volvo = new Bil("Volvo");
            
            Volvo.Registreringsnummer = "abc123";
            Volvo.Vikt = 200;
            Volvo.Registrering = DateTime.Now;
            Volvo.Elbil = false;
            Console.WriteLine("Hur många mil har Volvon åkt ");
            Volvo.Manipuleramilmätare(300);
            Volvo.Manipuleramilmätare(Convert.ToDouble(Console.ReadLine()));
            Billista.Add(Volvo);

            Bil Jeep = new Bil("Jeep");
            Jeep.Registreringsnummer = "jep321";
            Jeep.Vikt = 300;
            Jeep.Registrering = DateTime.Now;
            Jeep.Elbil = false;
            Console.WriteLine("Hur många mil har Jeepen åkt ");
            Jeep.Manipuleramilmätare(200);
            Jeep.Manipuleramilmätare(Convert.ToDouble(Console.ReadLine()));

            Billista.Add(Jeep);

            Bil Tesla = new Bil("Tesla");
            Tesla.Registreringsnummer = "tsl777";
            Tesla.Vikt = 100;
            Tesla.Registrering = DateTime.Now;
            Tesla.Elbil = true;
            Console.WriteLine("Hur många mil har Teslan åkt ");
            Tesla.Manipuleramilmätare(230);
            Tesla.Manipuleramilmätare(Convert.ToDouble(Console.ReadLine()));
            Billista.Add(Tesla);
            


            Bil Lambo = new Bil("Lambo");
            Lambo.Registreringsnummer = "lam676";
            Lambo.Vikt = 300;
            Lambo.Registrering = Lambo.Birthday;
            Lambo.Elbil = false;
            Console.WriteLine("Hur många mil har Lambon åkt ");
            Lambo.Manipuleramilmätare(20);
            Lambo.Manipuleramilmätare(Convert.ToDouble (Console.ReadLine()));
            
            Billista.Add(Lambo);

           
             void Getinfoaboutcar()
            {
                foreach (Bil curbil in Billista)
                {
                    curbil.BilInfo();

                }
            }

            Getinfoaboutcar();

            List<Person> personlista = new List<Person>();

            Person person;
            Skapaperson();
            void Skapaperson()
            {
                person = new Person();
                Console.WriteLine("Hej vad heter du?: ");
                person._Name = Console.ReadLine();

                Console.WriteLine("Hur gammal är du?: ");
                person._Age = Convert.ToInt32(Console.ReadLine());

                Skapabil();
                personlista.Add(person);
                Console.WriteLine("Vill du lägga till en ny person? ");
                string svar = Console.ReadLine();
                if (svar == "ja")
                {
                    Skapaperson();
                }
            }

           

            
            
            void Skapabil()
            {


                Console.WriteLine("Vad har du för bil?: ");
                string bilnamn = Console.ReadLine();
                Bil newcar = new Bil(bilnamn);
                Console.WriteLine("Vad har den för regnummer");
                newcar.Registreringsnummer = Console.ReadLine();
                Console.WriteLine("Vad väger bilen i kg");
                newcar.Vikt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("När registrerades bilen?: ");
                newcar.Registrering = newcar.Birthday;
                Console.WriteLine("Är det en elbil?: ");
                string svar = Console.ReadLine();
                if (svar == "ja")
                {
                    newcar.Elbil = true;

                }
                else newcar.Elbil = false;
               

                Console.WriteLine($"Hur många mil har {bilnamn} åkt  ");
                newcar.Manipuleramilmätare(Convert.ToDouble(Console.ReadLine()));
                person._Bilar.Add(newcar);
                Console.WriteLine("Vill du lägga till en bil?: ");
                svar = Console.ReadLine();

                if (svar == "ja")
                {
                    Skapabil();

                }

            }
            

            foreach (var p in personlista)
            {
                p.Personinfo();
            }
           

            
           
        }
    }

    public class Bil
    {
        public string Registreringsnummer { get; set; }
        public int Vikt { get; set; }
        public bool Elbil { get; set; }
        public DateTime Registrering { get; set; }
        public DateTime Birthday = new DateTime(1994, 07, 20);

        
        
        public  void BilInfo()
        {
            Console.WriteLine(
                $"\n Modell: {_Modellnamn}" +
                $"\n Registreringsnummer: {Registreringsnummer}" +
                $"\n Vikt: {Vikt}" +
                $"\n Registrerades: {Registrering}" +
                $"\nMilmätare: {_Milmätare}");
           
            if (Elbil)
            {
                Console.WriteLine(" Detta är en miljövänlig bil");
            }
        }

        private  string _Modellnamn;
        private double _Milmätare;
        
        public void Manipuleramilmätare(double milantal)
        {
            _Milmätare += milantal;
            
        }

      // public  List<Bil> Bilar { get; set; }
      // privata fält kan du använda i konstruktorn men måste tilldela namnet direkt
      // i new Bil, kan inte tilldela med =
        public Bil(string modellnamn)
        {
            _Modellnamn = modellnamn;
            

           // Bilar = new List<Bil>();
        }

       


    }
    
    public class Person
    {
        public string _Name { get; set; }
        public int _Age { get; set; }
        public List<Bil> _Bilar = new List<Bil>();

       
        public void Personinfo()
        {
            Console.WriteLine($" Namn {_Name}" +
                $"\n ålder {_Age}");

            foreach (var Bil in _Bilar)
            {
                Bil.BilInfo();
            }



        }
            
	

	
            
            

    }
}