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
            //ToimivaPesuohjelmointi();
        }
        //Tehtävän 2 Pesukoneen testaus
        static void VirheellinenPesuohjelmointi()
        {
            //luodaan pesukone -olio
            Pesukone pesukone = new JAMK.IT.Pesukone();
            //Pesukone päälle, vesihana auki, pesuohjelman valinta, veden lämmön valinta
            pesukone.OnkoPaalla = false;
            pesukone.VesihanaAuki = false;
            pesukone.Pesuohjelma = 5;
            pesukone.VedenLampo = 0;
            //näytetään konsolilla
            Console.WriteLine("Pesukone on päällä = {0}", pesukone.OnkoPaalla);
            Console.WriteLine("Vesihana on auki = {0}", pesukone.VesihanaAuki);
            Console.WriteLine("Valittu pesuohjelma = {0}", pesukone.Pesuohjelma);
            Console.WriteLine("Veden lämpötila = {0}", pesukone.VedenLampo);
        }
        static void ToimivaPesuohjelmointi()
        {
            //luodaan pesukone -olio
            Pesukone pesukone = new JAMK.IT.Pesukone();
            //Pesukone päälle, vesihana auki, pesuohjelman valinta, veden lämmön valinta
            pesukone.OnkoPaalla = true;
            pesukone.VesihanaAuki = true;
            pesukone.Pesuohjelma = 1;
            pesukone.VedenLampo = 40;
            //näytetään konsolilla
            Console.WriteLine("Pesukone on päällä = {0}", pesukone.OnkoPaalla);
            Console.WriteLine("Vesihana on auki = {0}", pesukone.VesihanaAuki);
            Console.WriteLine("Valittu pesuohjelma = {0}", pesukone.Pesuohjelma);
            Console.WriteLine("Veden lämpötila = {0}", pesukone.VedenLampo);
        }
    }
}
