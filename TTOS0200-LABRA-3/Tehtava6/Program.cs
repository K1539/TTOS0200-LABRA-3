using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelikoneet PS1 = new Pelikoneet("PS1", 1994, 102.49);
            Pelikoneet PS2 = new Pelikoneet("PS2", 2000, 157.608);
            Pelikoneet PS3 = new Pelikoneet("PS3", 2006, 80);
            Pelikoneet PS4 = new Pelikoneet("PS4", 2013, 50);

            List<Pelikoneet> PelikoneLista = new List<IT.Pelikoneet>();
            PelikoneLista.Add(PS1);
            PelikoneLista.Add(PS2);
            PelikoneLista.Add(PS3);
            PelikoneLista.Add(PS4);

            for (int i = 0; i < PelikoneLista.Count; i++)
            {
                Console.WriteLine("Konsoli numero " + (i+1) );
                Console.WriteLine("    Konsolin nimi: " + PelikoneLista[i].Nimi);
                Console.WriteLine("    Julkaisuvuosi : " + PelikoneLista[i].Julkaisuvuosi);
                Console.WriteLine("    Myytyjä konsoleita " + PelikoneLista[i].MyytyMaara + " miljoonaa kpl");
                Console.WriteLine();
            }
        }
    }
}
