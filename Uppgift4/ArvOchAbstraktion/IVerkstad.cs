using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    interface IVerkstad

    {

        public List<Fordon> fordoniverkstad { get; set; }
        public List<Bil> bilar { get; set; }
        public List<Lastbil> lastbilar { get; set; }
        public List<Motorcykel> motorcyklar { get; set; }
        public List<Buss> bussar { get; set; }
        public void Addfordon(Fordon fordon);

        public void Deletefordon(Fordon fordon);


        public void VisaFordon();

    }
}


