using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        //
        public void PrintData()
        {
            Console.WriteLine("Auton nimi : " + Name);
            Console.WriteLine("Auton nopeus : " + Speed);
            Console.WriteLine("Autossa Renkaita : " + Tyres);
        }
        public string ToString()
        {
            string PalautaKaikki;
            PalautaKaikki = Name + " " + Speed + " " + Tyres;
            return PalautaKaikki;
        }
    }
}
