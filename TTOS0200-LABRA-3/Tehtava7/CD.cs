using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public string SongName { get; set; }
        public CD(string songname)
        {
            SongName = songname;
        }
        public CD() {}
    }
}
