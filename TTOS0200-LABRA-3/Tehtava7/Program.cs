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
        static void Main()
        {
            MaaritaLevy();
        }

        static void MaaritaLevy()
        {
            
            CD cd = new CD();
            
            cd.Artist = "ZZ Top";
            cd.Name = "Afterburner";
            cd.Genre = "Rock";
            cd.Price = 6.65;
            

            CD S1 = new CD("Sleeping Bag  4:02");
            CD S2 = new CD("Stages  3:32");
            CD S3 = new CD("Woke Up With Wood  3:45");
            CD S4 = new CD("Rough Boy  4:50");
            CD S5 = new CD("Can't Stop Rockin'  3:01");
            CD S6 = new CD("Planet Of Women  4:04");
            CD S7 = new CD("I Got The Message  3:27");
            CD S8 = new CD("Velcro Fly  3:29");
            CD S9 = new CD("Dipping Low (In The Lap Of Luxury)  3:11");
            CD S10 = new CD("Delirious  3:41");

            List<CD> CDsongs = new List<IT.CD>();
            CDsongs.Add(S1);
            CDsongs.Add(S2);
            CDsongs.Add(S3);
            CDsongs.Add(S4);
            CDsongs.Add(S5);
            CDsongs.Add(S6);
            CDsongs.Add(S7);
            CDsongs.Add(S8);
            CDsongs.Add(S9);
            CDsongs.Add(S10);
            
            Console.WriteLine("CD: ");
            Console.WriteLine("-Artist: {0}", cd.Artist);
            Console.WriteLine("-Name: {0}", cd.Name);
            Console.WriteLine("-Genre: {0}", cd.Genre);
            Console.WriteLine("-Price: {0}e", cd.Price);
            Console.WriteLine("Songs:");
            

            for (int i = 0; i < CDsongs.Count; i++)
            {
                Console.WriteLine("--Name: {0}", CDsongs[i].SongName);

            }
        }

    }
}
