using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
           ToimivaTelevisioSetup();
           //ViallinenTelevisioSetup();
        }
        static void ToimivaTelevisioSetup()
        {
            Televisio salora = new Televisio();
            salora.OnkoTelevisioPaalla = true;
            salora.OnkoSignaali = true;
            salora.Kanava = 2;
            salora.Aanenvoimakkuus = 20;
            //
            Console.WriteLine("Televivio on päällä = {0}", salora.OnkoTelevisioPaalla);
            Console.WriteLine("Signaali on = {0}", salora.OnkoSignaali);
            Console.WriteLine("Valittu kanava = {0}", salora.Kanava);
            Console.WriteLine("Äänenvoimakkuus = {0}", salora.Aanenvoimakkuus);
        }
        static void ViallinenTelevisioSetup()
        {
            Televisio salora = new Televisio();
            salora.OnkoTelevisioPaalla = true;
            salora.OnkoSignaali = false;
            salora.Kanava = 4;
            salora.Aanenvoimakkuus = 666;
            //
            Console.WriteLine("Televivio on päällä = {0}", salora.OnkoTelevisioPaalla);
            Console.WriteLine("Signaali on = {0}", salora.OnkoSignaali);
            Console.WriteLine("Valittu kanava = {0}", salora.Kanava);
            Console.WriteLine("Äänenvoimakkuus = {0}", salora.Aanenvoimakkuus);
        }
    }
}