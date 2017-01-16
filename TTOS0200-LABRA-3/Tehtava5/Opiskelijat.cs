using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Opiskelija
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }
        public string Luokka { get; set; }

        public Opiskelija(string nimi, int ika, string luokka)
        {
            Nimi = nimi;
            Ika = ika;
            Luokka = luokka;
        }
    }
}
