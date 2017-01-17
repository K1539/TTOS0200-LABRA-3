using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pelikoneet
    {
        public string Nimi { get; set; }
        public int Julkaisuvuosi { get; set; }
        public double MyytyMaara { get; set; }

        public Pelikoneet(string nimi, int julkaisuvuosi, double myytymaara)
        {
            Nimi = nimi;
            Julkaisuvuosi = julkaisuvuosi;
            MyytyMaara = myytymaara;
        }

    }
}
