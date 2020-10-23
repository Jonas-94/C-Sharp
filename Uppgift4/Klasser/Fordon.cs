using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Fordon
    {
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