using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tehtava1;

namespace Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();
        }
        //Tehtävän 1 Kiuas-luokan testaus
        static void TestaaKiuas()
        {
            //luodaan kiuas -olio
            Kiuas kiuas = new Tehtava1.Kiuas();
            //pistetään kiuas lämpenemään ja asetetaan lämpö & kosteutta
            kiuas.OnkoPaalla = true;
            kiuas.Lampotila = 90;
            kiuas.Kosteus = 50;
            //näytetään konsolilla
            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPaalla);
            Console.WriteLine("Kiukaan lämpötila on {0}", kiuas.Lampotila);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
            //mitä tapahtuu jos kosteus yli rajojen
            kiuas.Kosteus = 101;
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
        }
    }
}
