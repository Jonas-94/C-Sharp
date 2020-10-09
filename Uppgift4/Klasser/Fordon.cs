using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Fordon
    {
        public List<Fordon> fordoniverkstad { get; set; } = new List<Fordon>();
        public List<Bil> bilar { get; set; } = new List<Bil>();
        public List<Lastbil> lastbilar { get; set; } = new List<Lastbil>();
        public List<Motorcykel> motorcyklar { get; set; } = new List<Motorcykel>();
        public List<Buss> bussar { get; set; } = new List<Buss>();
        public string _Modellnamn { get; set; }
        public string _Regnummer { get; set; }
        public double _Milmätare { get; set; }
        public DateTime _Registrering { get; set; }
        //public virtual void Visafordon()
        //{
        //    Console.WriteLine(
        //        $"\n Modellnamn:{_Modellnamn} " +
        //        $"\n Registreringsnummer:{_Regnummer} " +
        //        $"\n Registrering: {_Registrering} ");
            
        //}

    }
}