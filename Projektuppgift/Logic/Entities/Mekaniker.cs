using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    class Mekaniker
    {
        public string Name { get; set; }
        public string Födelsedatum { get; set; }
        public string Anställninsdatum { get; set; }
        public string Slutdatum { get; set; }
        public bool Kbromsar { get; set; }
        public bool Kmotor { get; set; }
        public bool Kkaross { get; set; }
        public bool Kvindruta { get; set; }
        public bool Kdäck { get; set; }

    }
}
