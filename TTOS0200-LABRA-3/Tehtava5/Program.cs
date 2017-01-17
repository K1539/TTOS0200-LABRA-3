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
            //tehdään listaan lisättävät objektit
            Opiskelija Jere = new Opiskelija("Jere", 20, "TTV16S3");
            Opiskelija Juuso = new Opiskelija("Juuso", 22, "TTV16S1");
            Opiskelija Matti = new Opiskelija("Matti", 19, "TTV16S2");
            Opiskelija Liisa = new Opiskelija("Liisa", 20, "TTV16S4");
            Opiskelija Alina = new Opiskelija("Alina", 20, "TTV16S4");

            List<Opiskelija> OpiskelijaLista = new List<Opiskelija>(); // luo lista ja lisää objektit
            OpiskelijaLista.Add(Jere);
            OpiskelijaLista.Add(Juuso);
            OpiskelijaLista.Add(Liisa);
            OpiskelijaLista.Add(Matti);
            OpiskelijaLista.Add(Alina);

            for (int i = 0; i < OpiskelijaLista.Count; i++) // käydään kaikki listan jäsenet läpi
            {
                Console.WriteLine("Opiskelija " + (i+1));
                Console.WriteLine("   Nimi: " + OpiskelijaLista[i].Nimi);
                Console.WriteLine("   Ikä: " + OpiskelijaLista[i].Ika);
                Console.WriteLine("   Luokka: " + OpiskelijaLista[i].Luokka);
                Console.WriteLine();
            }
        }
    }
}
