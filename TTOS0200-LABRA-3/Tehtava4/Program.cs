/*
 * Luo Vehicle-luokka seuraavien tietojen mukaisesti:

ominaisuudet

Name:string
Speed:int
Tyres:int
toiminnot

PrintData(), tulostaa Vehiclen ominaisuudet näytölle
ToString():string, palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona
Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jolla luot olion Vehicle-luokasta. Muuta olion arvoja ja tulosta olion arvoja konsolille.
*
* Jere Liikka 16.1.2017
* */
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
            string PalautaKaikki;
            Vehicle Auto = new Vehicle();
            Auto.Name = "Volvo";
            Auto.Speed = 420;
            Auto.Tyres = 4;
            Auto.PrintData();

            PalautaKaikki = Auto.ToString();
            Console.WriteLine(PalautaKaikki);
            Console.ReadLine();
        }

    }
}
