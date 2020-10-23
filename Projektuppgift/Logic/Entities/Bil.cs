using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    class Bil:Fordon
    {
        public bool Dragkrok { get; set; }
        public override void Registrerafordon()
        {
            
           base.Registrerafordon();
            if (Dragkrok)
            {
                Console.WriteLine("Bilen har dragkrok");
            }
            else
            {
                Console.WriteLine("Har inte dragkrok");

            }
        }
    }
}
