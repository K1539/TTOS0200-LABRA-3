using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pesukone
    {
        public bool OnkoPaalla { get; set; }
        public bool VesihanaAuki { get; set; }
        //tässä pesukoneessa vain kolme pesuohjelmaa
        float pesuohjelma;
        public float Pesuohjelma
        {
            get
            {
                return pesuohjelma;
            }
            set
            {
                pesuohjelma = value;
                if (pesuohjelma != 1 || pesuohjelma != 2 || pesuohjelma != 3)
                {
                    pesuohjelma = 1;
                }
            }
        }
        //Kosteus voi olla välillä 0 - 100
        float vedenlampo;
        public float VedenLampo
        {
            get
            {
                return vedenlampo;
            }
            set
            {
                vedenlampo = value;
                if (vedenlampo < 20 || vedenlampo > 100)
                {
                    VedenLampo = 20;
                }
            }
        }
    }
}
