using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Televisio
    {
        public bool OnkoTelevisioPaalla { get; set; }
        public bool OnkoSignaali { get; set; }
        float kanava;
        public float Kanava
        {
            get
            {
                return kanava;
            }
            set
            {
                if (kanava != 1 || kanava != 2 || kanava != 3)
                {
                    kanava = 1;
                }
            }
        }
        float aanenvoimakkuus;
        public float Aanenvoimakkuus
        {
            get
            {
                return aanenvoimakkuus;
            }
            set
            {
                aanenvoimakkuus = value;
                if (aanenvoimakkuus <= 0 || aanenvoimakkuus >= 50)
                {
                    aanenvoimakkuus = 0;
                }
            }
        }

    }
}
