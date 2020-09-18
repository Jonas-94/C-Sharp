using System;
using System.ComponentModel.DataAnnotations;

namespace Villkor_och_loopar
{

    /// <summary>


    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {


            int startNummer = 0;
            int startTimme = 0;
            int startMinut = 0;
            int startSekund = 0;
            int målTimme = 0;
            int målMinut = 0;
            int målSekund = 0;
            int slutTimme = 0;
            int slutMinut = 0;
            int slutSekund = 0;
            int bästaTid = int.MaxValue;
            int slutTid = 0;
            int deltagare = 0;
            int vinnare = 0;

            bool program = true;


            do
            {
                Console.Write("Ange ditt startnummer: ");
                startNummer = Convert.ToInt32(Console.ReadLine());

                if (startNummer == 0)
                {
                    Console.WriteLine($"Första platsen är startnummer" +
                            $" {vinnare} med tiden: " +
                            $"{slutTimme} Timmar " +
                            $"{slutMinut} Minuter " +
                            $"{slutSekund} Sekunder---");

                   

                    Console.WriteLine($"Antal deltagare: {deltagare}");

                    break;
                }
                

                Console.Write("Ange din starttimme: ");
                startTimme = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ange din startMinut: ");
                startMinut = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ange din startsekund: ");
                startSekund = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ange din måltimme: ");
                målTimme = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ange din målminut: ");
                målMinut = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ange din målsekund: ");
                målSekund = Convert.ToInt32(Console.ReadLine());


                deltagare++;





                int totalSekStart = startSekund + (startTimme * 3600) + (startMinut * 60);
                int totalSekMål = målSekund + (målTimme * 3600) + (målMinut * 60);

                slutTid = totalSekMål - totalSekStart;

                


                if (slutTid < bästaTid)
                {
                    bästaTid = slutTid;
                    vinnare = startNummer;
                }
                

                slutSekund = bästaTid % 60;

                slutMinut = (bästaTid / 60) % 60;

                slutTimme = bästaTid / 3600;

               if(slutSekund < 0)
               {
                    slutSekund += 24 * 3600;
                    
               }








                if (deltagare < 1)
                {
                    Console.WriteLine("Loppet hade inga deltagare");
                }

                



            } while (program);

        }
    }
}
