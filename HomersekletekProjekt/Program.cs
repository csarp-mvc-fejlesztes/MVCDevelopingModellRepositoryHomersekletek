using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HomersekletekProjekt.Tarolo;

namespace HomersekletekProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Meresek meresek=new Meresek();
            meresek.beolvas();

            Console.WriteLine("1. feladat");
            Console.WriteLine("Mérések száma: " + meresek.meresekSzama()+" db.");
            Console.WriteLine("2. feladat");
            Console.WriteLine("Legnagyobb hőmérséklet: " + meresek.maxHomerseklet()+" Celsius.");
            Console.WriteLine("3. feladat:");
            Console.WriteLine("Fagyos napok száma: "+meresek.getFagyosNapokSzama()+" db.");
            Console.WriteLine("4. feladat");
            Console.Write("Adja meg a keresett hőmérséklet számát: ");
            int homersekletSzam = Convert.ToInt32(Console.ReadLine());
            if (homersekletSzam < meresek.meresekSzama())
                meresek.kiirHomerseklet(homersekletSzam);
            Console.WriteLine("5. feladat");
            Console.WriteLine("Szeged város átleghőmérséklete: " + meresek.varosAtlaghomerseklete("Szeged") + " Celsius.");
            Console.WriteLine("6. feladat");
            Console.WriteLine("Városok száma: " + meresek.getVarosokSzama()+" db.");


            Console.ReadKey();
            

        }
    }
}
