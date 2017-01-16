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
            VirheellinenPesuohjelmointi();
            ToimivaPesuohjelmointi();
        }
        //Tehtävän 2 Pesukoneen testaus
        static void VirheellinenPesuohjelmointi()
        {
            //luodaan kiuas -olio
            Pesukone pesukone = new JAMK.IT.Pesukone();
            //Pesukone päälle, vesihana auki, pesuohjelman valinta, veden lämmön valinta
            pesukone.OnkoPaalla = false;
            pesukone.VesihanaAuki = false;
            pesukone.Pesuohjelma = "merinovillapesu";
            pesukone.VedenLampo = 0;
            //näytetään konsolilla
            Console.WriteLine("Pesukone on päällä = {0}", pesukone.OnkoPaalla);
            Console.WriteLine("Vesihana on auki = {0}", pesukone.VesihanaAuki);
            Console.WriteLine("Valittu pesuohjelma = {0}", pesukone.Pesuohjelma);
            Console.WriteLine("Veden lämpötila = {0}", pesukone.VedenLampo);
        }
        static void ToimivaPesuohjelmointi()
        {
            //luodaan kiuas -olio
            Pesukone pesukone = new JAMK.IT.Pesukone();
            //pistetään kiuas lämpenemään ja asetetaan lämpö & kosteutta
            pesukone.OnkoPaalla = true;
            pesukone.VesihanaAuki = true;
            pesukone.Pesuohjelma = "puuvillapesu";
            pesukone.VedenLampo = 40;
            //näytetään konsolilla
            Console.WriteLine("Pesukone on päällä = {0}", pesukone.OnkoPaalla);
            Console.WriteLine("Vesihana on auki = {0}", pesukone.VesihanaAuki);
            Console.WriteLine("Valittu pesuohjelma = {0}", pesukone.Pesuohjelma);
            Console.WriteLine("Veden lämpötila = {0}", pesukone.VedenLampo);
        }
    }
}
